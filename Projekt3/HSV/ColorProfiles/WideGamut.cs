using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV.ColorProfiles
{
    class WideGamut : ColorProfile
    { 
        public override double XRed => 0.7347;

        public override double YRed => 0.2653;

        public override double XGreen => 0.1152;

        public override double YGreen => 0.8264;

        public override double XBlue => 0.1566;

        public override double YBlue => 0.0177;

        public override double XWhite => 0.3457;

        public override double YWhite => 0.3585;

        public override double Gamma => 1.2;
    }
}
