using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Trapez : Shape
    {
        // Valuables for 2 extra sides
        protected double c;
        protected double d;

        
        // Constructor  that takes parameters
        public Trapez(double a, double b, double c, double d) : base(a, b)
        {
            this.c = c;
            this.d = d;
        }

        // Caclulates S
        public double SCal()
        {
            double s = (a + b + c + d) / 2;

            return s;
        }

        // Calculates Height
        public double HCal(double s)
        {
            double h = ((a - c) / 2) * Math.Sqrt(s * (s - a + c) * (s - b) * (s - d));

            return h;
        }

        
        // Calculates Perimitter
        public override double Perimiter()
        {
            return a + b + c + d;
        }

        // Calculates Area
        public override double Area()
        {
            return 0.5 * (a + c) * HCal(SCal());
        }
    }
}
