using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV.Iluminants
{
    abstract class Iluminant: IIluminant
    {
        public virtual bool WhiteEnabled => false;

        public abstract double XWhite { get; }

        public abstract double YWhite { get; }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
