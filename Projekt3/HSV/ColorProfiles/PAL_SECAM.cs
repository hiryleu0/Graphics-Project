using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV.ColorProfiles
{
    class PAL_SECAM : ColorProfile
    { 
        public override double XRed => 0.64;

        public override double YRed => 0.33;

        public override double XGreen => 0.29;

        public override double YGreen => 0.6;

        public override double XBlue => 0.15;

        public override double YBlue => 0.06;

        public override double XWhite => 0.3127;

        public override double YWhite => 0.3290;

        public override double Gamma => 1.95;
    }
}
