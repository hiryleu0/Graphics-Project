using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Projekt3
{
    public class Curve
    {
        public Point[] BezierPoints { get; set; }
        public int[] PlotPoints { get; set; }
        
        public Curve()
        {
            BezierPoints = new Point[]
            {
                new EndPoint(),
                new Point(),
                new Point(),
                new EndPoint()
            };
        }
        public Curve(DirectBitmap bitmap, int offset)
        {
            int x0 = offset;
            int x1 = bitmap.Width - offset - 1;
            int y0 = bitmap.Height - offset - 1;
            int y1 = offset;
            PlotPoints = new int[bitmap.Width];
            BezierPoints = new Point[]
            {
                new EndPoint(x0, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(2*x0/3 + x1/3, 2*y0/3+y1/3, bitmap.Width-1, bitmap.Height-1),
                new Point(x0/3 + 2*x1/3, y0/3 + 2*y1/3, bitmap.Width-1, bitmap.Height-1),
                new EndPoint(x1, y1, bitmap.Width-1, bitmap.Height-1)
            };
        }
        
        public void DrawPlot(Color color, DirectBitmap bitmap, double d)
        {
            double OX(double y) => bitmap.Height - y - 1;
            bool[] usedXs = new bool[bitmap.Width];

            double[] Ax =
            {
                BezierPoints[0].X,
                3 * (BezierPoints[1].X - BezierPoints[0].X),
                3 * (BezierPoints[2].X - 2 * BezierPoints[1].X + BezierPoints[0].X),
                BezierPoints[3].X - 3 * BezierPoints[2].X + 3 * BezierPoints[1].X - BezierPoints[0].X
            };

            double[] Ay =
            {
                OX(BezierPoints[0].Y),
                3 * (OX(BezierPoints[1].Y) - OX(BezierPoints[0].Y)),
                3 * (OX(BezierPoints[2].Y) - 2 * OX(BezierPoints[1].Y) + OX(BezierPoints[0].Y)),
                OX(BezierPoints[3].Y) - 3 * OX(BezierPoints[2].Y) + 3*OX(BezierPoints[1].Y) - OX(BezierPoints[0].Y)
            };

            double Px = Ax[0];
            double Py = Ay[0];
            double dPx = Ax[3] * d * d * d + Ax[2] * d * d + Ax[1] * d;
            double dPy = Ay[3] * d * d * d + Ay[2] * d * d + Ay[1] * d;
            double d2Px = 6 * Ax[3] * d * d * d + 2 * Ax[2] * d * d;
            double d2Py = 6 * Ay[3] * d * d * d + 2 * Ay[2] * d * d;
            double d3Px = 6 * Ax[3] * d * d * d;
            double d3Py = 6 * Ay[3] * d * d * d;

            PlotPoints[(int)Px] = (int)OX(Py);

            for (double i = d; i <= 1; i += d)
            {
                Px += dPx;
                Py += dPy;
                dPx += d2Px;
                dPy += d2Py;
                d2Px += d3Px;
                d2Py += d3Py;

                int y = (int)Math.Round(OX(Py));
                int x = (int)Math.Round(Px);
                if (!usedXs[x] || PlotPoints[x] > y)
                    PlotPoints[x] = y;
            }
            using (Graphics graphics = Graphics.FromImage(bitmap.Bitmap))
            {
                Pen pen = new Pen(color);
                for (int x = BezierPoints[0].X + 1; x <= BezierPoints[3].X; x++)
                    graphics.DrawLine(pen, x - 1, PlotPoints[x - 1], x, PlotPoints[x]);
            }
        }
        public void DrawPoints(DirectBitmap bitmap, int r)
        {
            using (Graphics g = Graphics.FromImage(bitmap.Bitmap))
            {
                foreach (Point p in BezierPoints)
                    g.DrawEllipse(Pens.Black, p.X - r, p.Y - r, 2 * r, 2 * r);
            }
        }
        
        public static bool SaveCurve(Curve curve, Bitmap bitmap, int offset)
        {
            try
            {
                int x0 = offset;
                int x1 = bitmap.Width - offset - 1;
                int y0 = bitmap.Height - offset - 1;
                int y1 = offset;
                double[] points = new double[8];
                for (int i = 0; i < 4; i++)
                {
                    Point p = curve.BezierPoints[i];
                    points[2 * i] = (x1 - p.X) / (x1 - x0 + 0.0);
                    points[2 * i + 1] = (y1 - p.Y) / (y1 - y0 + 0.0);
                }
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(double[]));
                    TextWriter writer = new StreamWriter(dialog.FileName);
                    serializer.Serialize(writer, points);
                    writer.Close();
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Niepowodzenie");
            }
            return false;
        }
        public static bool LoadCurve(Curve curve, Bitmap bitmap, int offset)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(double[]));
                    TextReader reader = new StreamReader(dialog.FileName);
                    double[] points = (double[])serializer.Deserialize(reader);
                    reader.Close();

                    int x0 = offset;
                    int x1 = bitmap.Width - offset - 1;
                    int y0 = bitmap.Height - offset - 1;
                    int y1 = offset;
                    for (int i = 0; i < 4; i++)
                    {
                        curve.BezierPoints[i].MaxX = bitmap.Width - 1;
                        curve.BezierPoints[i].MaxY = bitmap.Height - 1;
                        curve.BezierPoints[i].X = (int)Math.Round(points[2 * i] * x0 + (1 - points[2 * i]) * x1);
                        curve.BezierPoints[i].Y = (int)Math.Round(points[2 * i + 1] * y0 + (1 - points[2 * i + 1]) * y1);
                    }

                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Niepowodzenie", "Error", MessageBoxButtons.OK);
            }
            return false;
        }

        public bool MouseDown(int X, int Y, int R)
        {
            foreach (Point point in BezierPoints)
                if ((point.X - X) * (point.X - X) + (point.Y - Y) * (point.Y - Y) <= R * R)
                    return point.IsMoving = true;

            return false;
        }
        public void MouseMove(int x, int y)
        {
            foreach (Point point in BezierPoints)
                if (point.IsMoving)
                {
                    point.SetXY(x, y);
                    break;
                }
        }
        internal void MouseUp()
        {
            foreach (Point point in BezierPoints)
                if (point.IsMoving)
                {
                    point.IsMoving = false;
                    break;
                }
        }
    }
}
