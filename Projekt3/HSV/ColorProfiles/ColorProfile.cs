using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV.ColorProfiles
{
    abstract class ColorProfile : IColorProfile
    {
        public abstract double Gamma { get; }

        public virtual bool IluminantEnabled => false;

        public abstract double XRed { get; }

        public abstract double YRed { get; }

        public abstract double XGreen { get; }

        public abstract double YGreen { get; }

        public abstract double XBlue { get; }

        public abstract double YBlue { get; }

        public abstract double XWhite { get; }

        public abstract double YWhite { get; }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
