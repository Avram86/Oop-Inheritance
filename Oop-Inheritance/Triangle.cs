using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Inheritance
{
    public sealed class Triangle : Shape
    {
        public Triangle(Point p1, Point p2, Point p3):base(new Point[] { p1, p2, p3})
        {
        }

        public Point P1 { get { return Points[0]; } }
        public Point P2 { get { return Points[1]; } }
        public Point P3 { get { return Points[2]; } }

        public override string Name { get { return "Rectangle"; } }
        public override double Area 
        {
            get
            {
                // see: https://www.mathopenref.com/coordtrianglearea.html
                double area = Math.Abs(this.P1.X * (this.P2.Y - this.P3.Y) + this.P2.X * (this.P3.Y - this.P1.Y) + this.P3.X * (this.P1.Y - this.P2.Y)) / 2;
                return Math.Round(area, 2);
            }
        }

        public override void Rotate(double angleDegrees)
        {
            Console.WriteLine("Preparing to rotate a triangle....");
            base.Rotate(angleDegrees);
            Console.WriteLine("Finished rotating a triangle....");
        }
    }
}
