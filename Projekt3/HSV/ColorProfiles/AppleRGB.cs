using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV.ColorProfiles
{
    class AppleRGB : ColorProfile
    { 
        public override double XRed => 0.625;

        public override double YRed => 0.34;

        public override double XGreen => 0.28;

        public override double YGreen => 0.595;

        public override double XBlue => 0.155;

        public override double YBlue => 0.07;

        public override double XWhite => 0.3127;

        public override double YWhite => 0.3290;

        public override double Gamma => 1.8;
    }
}
