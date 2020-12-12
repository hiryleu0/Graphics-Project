using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3.HSV.Iluminants
{
    interface IIluminant
    {
        bool WhiteEnabled { get; }
        double XWhite { get; }
        double YWhite { get; }
    }
}
