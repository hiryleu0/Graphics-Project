using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV
{
    class HSVFilter : IFilter
    {
        public string Label1 => "H";

        public string Label2 => "S";

        public string Label3 => "V";

        public override string ToString()
        {
            return "HSV";
        }

        public bool PropertiesEnabled => false;

        public (Color, Color, Color) FilterColor(Color color)
        {
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;
            double c_max = Math.Max(Math.Max(r, g), b);
            double c_min = Math.Min(Math.Min(r, g), b);
            double delta = c_max - c_min;

            double H = 60.0, S, V;

            V = c_max;
            S = c_max == 0.0 ? 0 : delta / c_max;
            if (delta == 0) H = 0;
            else if (c_max == r) H *= ((g - b) / delta + 6) % 6;
            else if (c_max == g) H *= ((b - r) / delta + 2);
            else H *= (r - g) / delta + 4;

            Color gray(double val)
            {
                int v = (int)Math.Round(val * 255.0);
                return Color.FromArgb(v, v, v);
            }

            return (gray(H / 360.0), gray(S), gray(V));
        }
    }
}
