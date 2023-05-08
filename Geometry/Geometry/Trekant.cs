using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Trekant : Shape
    {
    
        // Constructor that takse parameters
        public Trekant(double a, double b) : base(a,b)
        {
            
        }

        // Calculates C
        public double CCal()
        {
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return c;
        }

        // Calculates Perimitter
        public override double Perimiter()
        {
            return a + b + CCal();
        }

        // Calculates Area
        public override double Area()
        {
            return 0.5 * a * b;
        }
    }
}
