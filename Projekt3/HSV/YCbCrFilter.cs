using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV
{
    class YCbCrFilter : IFilter
    {
        public string Label1 => "Y";

        public string Label2 => "Cb";

        public string Label3 => "Cr";

        public override string ToString() => "YCbCr";

        public bool PropertiesEnabled => false;

        public (Color, Color, Color) FilterColor(Color color)
        {
            int red = color.R;
            int green = color.G;
            int blue = color.B;

            int Y = (int)Math.Round((0.299 * red) + (0.587 * green) + (0.114 * blue));
            int Cb = (int)Math.Round(((blue-Y) / 1.772 + 127));
            int Cr = (int)Math.Round(((red-Y) / 1.402 + 127));

            Color c1 = Color.FromArgb(Y, Y, Y);
            Color c2 = Color.FromArgb(127, 255 - Cb, Cb);
            Color c3 = Color.FromArgb(Cr, 255 - Cr, 127);

            return (c1, c2, c3);
        }
    }
}
