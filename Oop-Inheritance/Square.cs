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
        {
            TopLeft = topLeft;
            TopRight = new Point(TopLeft.X + width, TopLeft.Y);
            BottomRight = new Point(TopRight.X, TopLeft.Y + height);
            BottomLeft = new Point(TopLeft.X, TopLeft.Y + height);
        }
        public Point TopLeft { get; }
        public Point TopRight { get; }
        public Point BottomLeft { get; }
        public Point BottomRight { get; }



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
