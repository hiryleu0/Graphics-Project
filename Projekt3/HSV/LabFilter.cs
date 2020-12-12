using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace Projekt3.HSV
{
    class LabFilter : IFilter
    {
        private HSVForm mainForm;

        public LabFilter(HSVForm form)
        {
            this.mainForm = form;
        }

        public string Label1 => "L";

        public string Label2 => "a";

        public string Label3 => "b";

        public override string ToString() => "Lab";

        public bool PropertiesEnabled => true;
        public (Color, Color, Color) FilterColor(Color color)
        {
            double xr = (double)mainForm.redXNumericUpDown.Value;
            double yr = (double)mainForm.redYNumericUpDown.Value;
            double xg = (double)mainForm.greenXNumericUpDown.Value;
            double yg = (double)mainForm.greenYNumericUpDown.Value;
            double xb = (double)mainForm.blueXNumericUpDown.Value;
            double yb = (double)mainForm.blueYNumericUpDown.Value;
            double xw = (double)mainForm.whiteXNumericUpDown.Value;
            double yw = (double)mainForm.whiteYNumericUpDown.Value;
            double gamma = (double)mainForm.gammaNumericUpDown.Value;

            Matrix<double> m = CreateMatrix.DenseOfColumnArrays(
                new double[]{xr,xg,xb },
                new double[]{yr,yg,yb },
                new double[]{1-xr-yr,1-xg-yg,1-xb-yb });

            Matrix<double> v = CreateMatrix.DenseOfColumnArrays(
                new double[] { xw / yw, 1, (1 - xw - yw) / yw });

            Matrix<double> inv = m.Transpose().Inverse();

            Matrix<double> s = inv * v;
            double sr = s[0, 0];
            double sg = s[1, 0];
            double sb = s[2, 0];

            Matrix<double> x = CreateMatrix.DenseOfColumnArrays(
                new double[] { xr*sr, xg*sg, xb*sb },
                new double[] { yr*sr, yg*sg, yb*sb },
                new double[] { (1 - xr - yr)*sr, (1 - xg - yg)*sg, (1 - xb - yb)*sb });

            Matrix<double> rgb = CreateMatrix.DenseOfColumnArrays(
                new double[] {Math.Pow(color.R/255.0,1/gamma)*255, Math.Pow(color.G / 255.0, 1/gamma) * 255, Math.Pow(color.B / 255.0, 1/gamma) * 255 });

            Matrix<double> c = x * rgb;
            double X, Y, Z;
            X = c[0, 0];
            Y = c[1, 0];
            Z = c[2, 0];

            double XR = 94.81;
            double YR = 100.0;
            double ZR = 107.3;
            double dY = Y / YR;
            double dX = X / XR;
            double dZ = Z / ZR;
            double sdY = Math.Pow(dY, 1 / 3.0);
            double sdX = Math.Pow(dX, 1 / 3.0);
            double sdZ = Math.Pow(dZ, 1 / 3.0);
            int L = dY > 0.008856 ? (int)Math.Round(116 * sdY) - 16 : (int)Math.Round(903.3 * dY);
            int a = (int)Math.Round(500 * (sdX - sdY));
            int b = (int)Math.Round(200 * (sdY - sdZ));

            if (L < 0) L = 0;
            else if (L > 255) L = 255;

            if (a < -127) a = -127;
            else if (a > 127) a = 127;

            if (b < -127) b = -127;
            else if (b > 127) b = 127;

            return (Color.FromArgb(L, L, L), Color.FromArgb(127+a, 127-a,127), Color.FromArgb(127+b, 127, 127-b));
        }
    }
}
