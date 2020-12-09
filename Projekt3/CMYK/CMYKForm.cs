using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3
{
    public partial class CMYKForm : Form
    {
        public Curve cyjanCurve;
        public Curve magentaCurve;
        public Curve yellowCurve;
        public Curve blackCurve;

        private Curve movingCurve;
        private Color movingCurveColor;
        private bool moving;

        private bool showingAllCurves = true;
        private const int coordinateOffset = 10;
        private const int pointR = 5;
        private const double precision = 0.000005;

        public DirectBitmap mainBitmap = null;
        public DirectBitmap plotBitmap = null;

        private MainForm mainForm;
        public CMYKForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            plotBitmap = new DirectBitmap(plotPictureBox.Width, plotPictureBox.Height);
            plotPictureBox.Image = plotBitmap.Bitmap;

            cyjanCurve = new Curve(plotBitmap, coordinateOffset);
            magentaCurve = new Curve(plotBitmap, coordinateOffset);
            yellowCurve = new Curve(plotBitmap, coordinateOffset);
            blackCurve = new Curve(plotBitmap, coordinateOffset);

            cyjanCurve.BezierPoints[3].Y += 20;
            magentaCurve.BezierPoints[3].Y += 40;
            yellowCurve.BezierPoints[3].Y += 60;

            cyjanCurve.BezierPoints[1].Y += 10;
            magentaCurve.BezierPoints[1].Y += 20;
            yellowCurve.BezierPoints[1].Y += 30;

            movingCurve = cyjanCurve;
            movingCurveColor = Color.Cyan;

            DrawPlots();

            Bitmap bitmap = new Bitmap(".\\pictures\\drzewo.jpg");
            mainBitmap = new DirectBitmap(bitmap.Width, bitmap.Height);
            for (int i = 0; i < mainBitmap.Width; i++)
                for (int j = 0; j < mainBitmap.Height; j++)
                    mainBitmap.SetPixel(i, j, bitmap.GetPixel(i, j));
            mainPictureBox.Image = mainBitmap.Bitmap;
        }

        public int ValueFromPlot(int k, Curve curve)
        {
            int x = (int)Math.Round(k  * (plotBitmap.Width  - 2 * coordinateOffset) / 255.0 + coordinateOffset);
            if (x < coordinateOffset) x = coordinateOffset;
            else if (x > plotBitmap.Width - coordinateOffset - 1) x = plotBitmap.Width - coordinateOffset - 1;
            int y = plotBitmap.Height - 1 - curve.PlotPoints[x];
            double d = (y - coordinateOffset + 0.0) / (plotBitmap.Height - 2 * coordinateOffset); 
            return (int)(255 * d);
        }

        private void DrawPlots()
        {
            for (int i = 0; i < plotBitmap.Width; i++)
                for (int j = 0; j < plotBitmap.Height; j++)
                    plotBitmap.SetPixel(i, j, SystemColors.GrayText);

            for (int i = coordinateOffset; i < plotBitmap.Width - coordinateOffset; i++)
                plotBitmap.SetPixel(i, plotBitmap.Height - coordinateOffset, Color.Black);
            for (int i = coordinateOffset; i < plotBitmap.Height - coordinateOffset; i++)
                plotBitmap.SetPixel(coordinateOffset, i, Color.Black);

            if (showingAllCurves)
            {
                blackCurve.DrawPlot(Color.Black, plotBitmap, precision);
                yellowCurve.DrawPlot(Color.Yellow, plotBitmap, precision);
                magentaCurve.DrawPlot(Color.Magenta, plotBitmap, precision);
                cyjanCurve.DrawPlot(Color.Cyan, plotBitmap, precision);
            }
            else
            {
                movingCurve.DrawPlot(movingCurveColor, plotBitmap, precision);
            }

            movingCurve.DrawPoints(plotBitmap, pointR);

            plotPictureBox.Refresh();
        }

        private void allCurvesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            showingAllCurves = allCurvesCheckBox.Checked;
            DrawPlots();
        }

        private void cyjanButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cyjanButton.Checked)
            {
                movingCurve = cyjanCurve;
                movingCurveColor = Color.Cyan;
                DrawPlots();
            }

        }
        private void magentaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (magentaButton.Checked)
            {
                movingCurve = magentaCurve;
                movingCurveColor = Color.Magenta;
                DrawPlots();
            }
        }
        private void yellowButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowButton.Checked)
            {
                movingCurve = yellowCurve;
                movingCurveColor = Color.Yellow;
                DrawPlots();
            }
        }
        private void blackButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blackButton.Checked)
            {
                movingCurve = blackCurve;
                movingCurveColor = Color.Black;
                DrawPlots();
            }
        }

        private void allPicturesButton_Click(object sender, EventArgs e)
        {
            new AllPicturesForm(this).ShowDialog();
        }

        private void changePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "pictures"),
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                mainTableLayoutPanel.Enabled = false;
                Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                mainBitmap = new DirectBitmap(bitmap.Width, bitmap.Height);
                for (int i = 0; i < mainBitmap.Width; i++)
                    for (int j = 0; j < mainBitmap.Height; j++)
                        mainBitmap.SetPixel(i, j, bitmap.GetPixel(i, j));
                mainPictureBox.Image = mainBitmap.Bitmap;
                mainPictureBox.Refresh();
            }
            mainTableLayoutPanel.Enabled = true;
        }
        private void blackWhiteButton_Click(object sender, EventArgs e)
        {
            mainTableLayoutPanel.Enabled = false;
            for (int y = 0; y < mainBitmap.Height; y++)
                for (int x = 0; x < mainBitmap.Width; x++)
                {
                    Color c = mainBitmap.GetPixel(x, y);
                    int rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    mainBitmap.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            mainPictureBox.Refresh();
            mainTableLayoutPanel.Enabled = true;
        }

        private void plotPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            moving = movingCurve.MouseDown(e.X, e.Y, pointR);
        }
        private void plotPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            movingCurve.MouseUp();
            moving = false;
        }
        private void plotPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                movingCurve.MouseMove(e.X, e.Y);
                DrawPlots();
            }
        }

        private void saveCurveButton_Click(object sender, EventArgs e)
        {
            if (Curve.SaveCurve(movingCurve, plotBitmap.Bitmap, coordinateOffset))
                MessageBox.Show("Zapisano!", "Done", MessageBoxButtons.OK);
        }
        private void loadCurveButton_Click(object sender, EventArgs e)
        {
            if (Curve.LoadCurve(movingCurve, plotBitmap.Bitmap, coordinateOffset))
                DrawPlots();
        }
        private void savePicturesButton_Click(object sender, EventArgs e)
        {
            new AllPicturesForm(this).SavePictures();
        }

        private void _0Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                blackCurve.BezierPoints[i].Y = plotBitmap.Height - coordinateOffset;
            }
            magentaCurve.BezierPoints[3].Y = yellowCurve.BezierPoints[3].Y = coordinateOffset;
            int offset = coordinateOffset;
            DirectBitmap bitmap = plotBitmap;
            int x0 = offset;
            int x1 = bitmap.Width - offset;
            int y0 = bitmap.Height - offset;
            int y1 = offset;
            cyjanCurve.BezierPoints = new Point[]
            {
                new EndPoint(x0, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(2*x0/3 + x1/3, 2*y0/3+y1/3, bitmap.Width-1, bitmap.Height-1),
                new Point(x0/3 + 2*x1/3, y0/3 + 2*y1/3, bitmap.Width-1, bitmap.Height-1),
                new EndPoint(x1, y1, bitmap.Width-1, bitmap.Height-1)
            };

            magentaCurve.BezierPoints[0].Y = yellowCurve.BezierPoints[0].Y = y0;
            magentaCurve.BezierPoints[0].Y = yellowCurve.BezierPoints[0].Y = y0;

            magentaCurve.BezierPoints[1].SetXY(2 * x0 / 3 + x1 / 3, 2 * y0 / 3 + y1 / 3 + 70);
            yellowCurve.BezierPoints[1].SetXY(2 * x0 / 3 + x1 / 3, 2 * y0 / 3 + y1 / 3 + 70);

            magentaCurve.BezierPoints[2].SetXY(x0 / 3 + 2 * x1 / 3, y0 / 3 + 2 * y1 / 3 + 70);
            yellowCurve.BezierPoints[2].SetXY(x0 / 3 + 2 * x1 / 3, y0 / 3 + 2 * y1 / 3 + 100);

            DrawPlots();
        }
        private void _100Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                cyjanCurve.BezierPoints[i].Y = plotBitmap.Height - coordinateOffset;
                magentaCurve.BezierPoints[i].Y = plotBitmap.Height - coordinateOffset;
                yellowCurve.BezierPoints[i].Y = plotBitmap.Height - coordinateOffset;
            }
            int offset = coordinateOffset;
            DirectBitmap bitmap = plotBitmap;
            int x0 = offset;
            int x1 = bitmap.Width - offset;
            int y0 = bitmap.Height - offset;
            int y1 = offset;
            blackCurve.BezierPoints = new Point[]
            {
                new EndPoint(x0, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(2*x0/3 + x1/3, 2*y0/3+y1/3, bitmap.Width-1, bitmap.Height-1),
                new Point(x0/3 + 2*x1/3, y0/3 + 2*y1/3, bitmap.Width-1, bitmap.Height-1),
                new EndPoint(x1, y1, bitmap.Width-1, bitmap.Height-1)
            };
            DrawPlots();
        }
        private void UCRButton_Click(object sender, EventArgs e)
        {
            int offset = coordinateOffset;
            DirectBitmap bitmap = plotBitmap;
            int x0 = offset;
            int x1 = bitmap.Width - offset;
            int y0 = bitmap.Height - offset;
            int y1 = offset;
            blackCurve.BezierPoints = new Point[]
            {
                new EndPoint(x0, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(x1, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(x1, y0, bitmap.Width-1, bitmap.Height-1),
                new EndPoint(x1, y1, bitmap.Width-1, bitmap.Height-1)
            };
            cyjanCurve.BezierPoints = new Point[]
            {
                new EndPoint(x0, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(7*x0/20+15*x1/20, y0/4+3*y1/3, bitmap.Width - 1, bitmap.Height-1),
                new Point(3*x0/10+7*x1/10, y0/4+3*y1/4, bitmap.Width-1, bitmap.Height-1),
                new EndPoint(x1, 3*y1/4 + y0/4, bitmap.Width-1, bitmap.Height-1)
            };
            magentaCurve.BezierPoints = new Point[]
            {
                new EndPoint(x0, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(6*x0/25+19*x1/25, 21*y0/50+29*y1/50, bitmap.Width - 1, bitmap.Height-1),
                new Point(x0/4+3*x1/4, 9*y0/25+16*y1/25, bitmap.Width-1, bitmap.Height-1),
                new EndPoint(x1, 16*y1/25 + 9*y0/25, bitmap.Width-1, bitmap.Height-1)
            };
            yellowCurve.BezierPoints = new Point[]
            {
                new EndPoint(x0, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(3*x0/10+7*x1/10, 23*y0/50+27*y1/50, bitmap.Width - 1, bitmap.Height-1),
                new Point(3*x0/10+7*x1/10, 21*y0/50+29*y1/50, bitmap.Width-1, bitmap.Height-1),
                new EndPoint(x1, 29*y1/50 + 21*y0/50, bitmap.Width-1, bitmap.Height-1)
            };
            DrawPlots();
        }
        private void GCRButton_Click(object sender, EventArgs e)
        {
            int offset = coordinateOffset;
            DirectBitmap bitmap = plotBitmap;
            int x0 = offset;
            int x1 = bitmap.Width - offset;
            int y0 = bitmap.Height - offset;
            int y1 = offset;
            blackCurve.BezierPoints = new Point[]
            {
                new EndPoint(x0, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(x1, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(x0/8+7*x1/8, y0, bitmap.Width-1, bitmap.Height-1),
                new EndPoint(x1, y1, bitmap.Width-1, bitmap.Height-1)
            };
            cyjanCurve.BezierPoints = new Point[]
            {
                new EndPoint(x0, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(x0/2+x1/2, y0/2+y1/2, bitmap.Width - 1, bitmap.Height-1),
                new Point(x0/2+x1/2, y0/4+3*y1/4, bitmap.Width-1, bitmap.Height-1),
                new EndPoint(x1, 3*y1/4 + y0/4, bitmap.Width-1, bitmap.Height-1)
            };
            magentaCurve.BezierPoints = new Point[]
            {
                new EndPoint(x0, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(x0/2+x1/2, y0/2+y1/2, bitmap.Width - 1, bitmap.Height-1),
                new Point(x0/2+x1/2, 3*y0/8+5*y1/8, bitmap.Width-1, bitmap.Height-1),
                new EndPoint(x1, 62*y1/100 + 38*y0/100, bitmap.Width-1, bitmap.Height-1)
            };
            yellowCurve.BezierPoints = new Point[]
            {
                new EndPoint(x0, y0, bitmap.Width-1, bitmap.Height-1),
                new Point(x0/2+x1/2, y0/2+y1/2, bitmap.Width - 1, bitmap.Height-1),
                new Point(x0/2+x1/2, 7*y0/16+9*y1/16, bitmap.Width-1, bitmap.Height-1),
                new EndPoint(x1, 58*y1/100 + 42*y0/100, bitmap.Width-1, bitmap.Height-1)
            };
            DrawPlots();
        }
    }
}
