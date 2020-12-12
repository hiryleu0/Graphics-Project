using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV.Iluminants
{
    class MyIluminant : Iluminant
    {
        public override bool WhiteEnabled => true;

        public override double XWhite => throw new NotImplementedException();

        public override double YWhite => throw new NotImplementedException();
    }
}
