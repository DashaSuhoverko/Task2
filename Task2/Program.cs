using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(14,19,22);
            Console.WriteLine(triangle.IsRightTriangle());
        }
    }
}
