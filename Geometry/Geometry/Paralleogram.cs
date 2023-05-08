using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Paralleogram : Shape
    {

        // A valuable for the angle
        protected double v;

        
        // Constructor that takes parameters
        public Paralleogram(double a, double b, double v) : base(a, b)
        {
            this.v = v;
        }

        // Calculates Perimitter
        public override double Perimiter()
        {
            return (a + b) * 2;
        }

        // Calculates Area
        public override double Area()
        {
            return a * b * Math.Sin(v);
        }
    }
}
