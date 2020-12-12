using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV.ColorProfiles
{
    interface IColorProfile
    {
        double Gamma { get; }
        bool IluminantEnabled { get; }
        double XRed { get; }
        double YRed { get; }
        double XGreen { get; }
        double YGreen { get; }
        double XBlue { get; }
        double YBlue { get; }
        double XWhite { get; }
        double YWhite { get; }
    }
}
