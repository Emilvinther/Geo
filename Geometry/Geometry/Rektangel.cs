using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rektangel : Shape
    {

        // Constructor taking 2 parameters
        public Rektangel(double a, double b) : base(a, b)
        {
            
        }


        // Calculate Parimiter
        public override double Perimiter()
        {
            return 2 * (a * b);
        }

        // Calculate Area
        public override double Area()
        {
            return a * b;
        }
    }
}
