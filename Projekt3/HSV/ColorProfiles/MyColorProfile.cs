using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV.ColorProfiles
{
    class MyProfile : ColorProfile
    {
        public override bool IluminantEnabled => true;

        public override double Gamma => throw new NotImplementedException();

        public override double XRed => throw new NotImplementedException();

        public override double YRed => throw new NotImplementedException();

        public override double XGreen => throw new NotImplementedException();

        public override double YGreen => throw new NotImplementedException();

        public override double XBlue => throw new NotImplementedException();

        public override double YBlue => throw new NotImplementedException();

        public override double XWhite => throw new NotImplementedException();

        public override double YWhite => throw new NotImplementedException();
    }
}
