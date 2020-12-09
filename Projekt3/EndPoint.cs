using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3
{
    public class EndPoint:Point
    {
        public EndPoint(int X, int Y, int maxX, int maxY) : base(X, Y, maxX, maxY) { }
        public EndPoint() : base() { }
        public override void SetXY(int X, int Y)
        {
            if (Y < 0) Y = 0;
            else if (Y > MaxY) Y = MaxY;
            this.Y = Y;
        }
    }
}
