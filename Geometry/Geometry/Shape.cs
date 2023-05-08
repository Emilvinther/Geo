using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Shape
    {
        // Valueables for side a and b
        protected double a;
        protected double b;

        // Constructor that takes parameters
        public Shape(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        // Abstract methods used in sub classes
        public abstract double Perimiter();


        public abstract double Area();


    }
}
