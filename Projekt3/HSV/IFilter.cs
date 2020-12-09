using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV
{
    interface IFilter
    {
        string Label1 { get; }
        string Label2 { get; }
        string Label3 { get; }
        string ToString();
        bool PropertiesEnabled { get; }
        (Color, Color, Color) FilterColor(Color color);
    }

}
