using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Square : Shape
    {

        // Constructor taking 2 parameters
        public Square(double a, double b) : base(a, b)
        {

        }

        // Calculate area
        public override double Area()
        {
            return a * b;
        }

        // Calculate Perimiter
        public override double Perimiter()
        {
            return (a + b) * 2;
        }
    }
}

