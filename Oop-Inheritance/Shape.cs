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

        public abstract string Name { get; }
        public Point[] Points { get; }

        public abstract double Area { get; }

        public virtual void Rotate(double angleDegrees)
        {
            Console.WriteLine($"Rotating base shape with {angleDegrees} degrees");

            foreach(var point in Points)
            {
                point.ApplyRotationTransform(angleDegrees);
            }
        }

    }
}
