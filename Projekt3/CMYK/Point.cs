using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int MaxX { get; set; }
        public int MaxY {get; set;}
        public bool IsMoving { get; set; }
        public Point () { }
        public Point(int X, int Y, int maxX = int.MaxValue, int maxY = int.MaxValue)
        {
            this.X = X; 
            this.Y = Y;
            MaxX = maxX;
            MaxY = maxY;
        }
        public virtual void SetXY(int X, int Y)
        {
            if (X < 0) X = 0;
            else if (X > MaxX)  X = MaxX;
            if (Y < 0) Y = 0;
            else if (Y > MaxY) Y = MaxY;
            this.X = X;
            this.Y = Y;
        }
    }
}
