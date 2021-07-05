using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Inheritance
{
    public class Square : Shape
    {
        public Square(Point topLeft, int width, int height)
        : base(new Point[]
            {
                topLeft, 
                new Point(topLeft.X + width, topLeft.Y),
                new Point(topLeft.X+width, topLeft.Y + height),
                new Point(topLeft.X, topLeft.Y + height)
            })
        {
        }
        public Point TopLeft {
            get { 
                return Points[0];
            }
        }
        public Point TopRight
        {
            get
            {
                return Points[1];
            }
        }
        public Point BottomRight
        {
            get
            {
                return Points[2];
            }
        }
        public Point BottomLeft
        {
            get
            {
                return Points[3];
            }
        }


        public override string Name { get { return "Triangle"; } }

        public override double Area {
            get 
            {
                double area = Math.Abs((TopLeft.X * TopRight.Y - TopLeft.Y * TopRight.X) + 
                                       (TopRight.X * BottomRight.Y - TopRight.Y * BottomRight.X) +
                                       (BottomRight.X * BottomLeft.Y - BottomRight.Y * BottomLeft.X) + 
                                       (BottomLeft.X * TopLeft.Y - BottomLeft.Y * TopLeft.X)) / 2;

                return area;
            }
        }

        public override void Rotate(double angleDegrees)
        {
            TopLeft.ApplyRotationTransform(angleDegrees);
            TopRight.ApplyRotationTransform(angleDegrees);
            BottomRight.ApplyRotationTransform(angleDegrees);
            BottomLeft.ApplyRotationTransform(angleDegrees);
        }
    }
}
