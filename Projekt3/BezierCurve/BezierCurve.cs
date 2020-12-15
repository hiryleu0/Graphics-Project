using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt3.BezierCurve
{
    class BezierCurve
    {
        public static int r = 5;
        public static double precision = 0.001;
        private Point movingPoint;
        List<Point> points = new List<Point>();
        public BezierCurve(int n, int width, int height)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < n; i++)
                points.Add(new Point(random.Next(0, width), random.Next(0, height), width - 1, height - 1));
        }
        public void DrawCurve(Graphics graphics, bool polylineVisible, DirectBitmap bitmap)
        {
            if (points.Count > 0)
            {
                
                List<Point> finalPixels = new List<Point>();
                for (double t = 0.0; t <= 1; t += precision)
                {
                    List<Point> temp1 = new List<Point>(points);
                    while (temp1.Count > 1)
                    {
                        List<Point> temp2 = new List<Point>();
                        for (int i = 0; i < temp1.Count - 1; i++)
                        {
                            Point pt1 = temp1[i];
                            Point pt2 = temp1[i + 1];
                            temp2.Add(LinearInterpolation(pt1, pt2, t));
                        }
                        temp1 = temp2;
                    }
                    finalPixels.Add(temp1[0]);
                }
                for(int i=0; i<finalPixels.Count-1;i++)
                {
                    graphics.DrawLine(Pens.Black, finalPixels[i].X, finalPixels[i].Y, finalPixels[i + 1].X, finalPixels[i + 1].Y);
                }

            }
            if (polylineVisible)
            {
                for (int i = 0; i < points.Count - 1; i++)
                    graphics.DrawLine(Pens.Red, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);

                foreach (Point p in points)
                    graphics.FillEllipse(Brushes.Black, p.X - r, p.Y - r, 2 * r, 2 * r);
            }
        }

        public void MouseMove(int x, int y)
        {
            movingPoint?.SetXY(x, y);
        }

        public bool MouseDown(int x, int y)
        {
            foreach(Point p in points)
                if((p.X-x) * (p.X-x) + (p.Y-y)*(p.Y-y)<= r*r)
                {
                    movingPoint = p;
                    return true;
                }
            return false;
        }

        private Point LinearInterpolation(Point pt1, Point pt2, double t)
        {
            int x = (int)Math.Round(pt1.X + t * (pt2.X - pt1.X));
            int y = (int)Math.Round(pt1.Y + t * (pt2.Y - pt1.Y));
            return new Point(x, y, pt1.MaxX, pt1.MaxY);
        }
    }
}
