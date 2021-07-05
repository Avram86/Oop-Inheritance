using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Inheritance
{
    public abstract class Shape
    {
        public Shape( Point[] points)
        {
            this.Points = points ?? new Point[0];
        }

        public Point[] Points { get; }

        public abstract double Area { get; }

        public void Rotate(double angleDegrees)
        {
            foreach(var point in Points)
            {
                point.ApplyRotationTransform(angleDegrees);
            }
        }

    }
}
