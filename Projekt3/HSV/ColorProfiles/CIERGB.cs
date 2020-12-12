using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV.ColorProfiles
{
    class CIERGB : ColorProfile
    { 
        public override double XRed => 0.735;

        public override double YRed => 0.265;

        public override double XGreen => 0.274;

        public override double YGreen => 0.717;

        public override double XBlue => 0.1670;

        public override double YBlue => 0.0090;

        public override double XWhite => 1 / 3.0;

        public override double YWhite => 1 / 3.0;

        public override double Gamma => 2.2;
    }
}
