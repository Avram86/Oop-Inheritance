using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Inheritance
{
    public abstract class Shape
    {
        public abstract double Area { get; }

        public abstract void Rotate(double angleDegrees);

    }
}
