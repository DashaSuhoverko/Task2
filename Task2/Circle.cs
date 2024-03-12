using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   public  class Circle : IShape
    {
        public double Radius { get; }
        public Circle()
        {

        }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Must specify a positive radius value");
            else this.Radius = radius;

        }
        public double GetArea() 
        {
          double result = Math.PI* Math.Pow(Radius, 2);
            return result;
        }
       
    }
}
