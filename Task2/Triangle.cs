using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   public  class Triangle : IShape
    {
        readonly double [] sides;
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle()
        {

        }
        public Triangle(double side1 , double side2 , double side3)
        {
            sides = new double [] { side1, side2, side3 };
            if (sides.Any(x => x <= 0))
            {
                throw new ArgumentException("Must specify a positive  value");
            }
            else if (side1 + side2 < side3 || side2 + side3 < side1 || side1 + side3 < side2)
            {

                throw new ArgumentException("The specified parameters do not correspond to the triangle shape");
            }

            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        
        public double GetArea()
        {
            
            
                double r = (Side1 + Side2 + Side3) / 2;
                double result = Math.Sqrt(r * (r - Side1) * (r - Side2) * (r - Side3));
            return result;
            
        }

        public bool IsRightTriangle(double e = 1E-6)
        {
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[0], 2) +Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) <= e;
            

        }

       

    }
}
