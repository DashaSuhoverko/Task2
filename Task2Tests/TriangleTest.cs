using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;


namespace Task2Tests
{
    [TestClass]

    public class TriangleTest
    {
        [TestMethod]

        public void GetAreaWithPositiveValues()
        {
            double side1 = 5;
            double side2 = 7;
            double side3 = 9;
            Triangle triangle = new Triangle(side1, side2, side3);

            var expected = 17.41228014936585;

            double actual = triangle.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]

        public void GetAreaWithZeroValues()
        {

            double side1 = 0;
            double side2 = 7;
            double side3 = 9;

            Triangle triangle = new Triangle(side1, side2, side3);
        }

        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]

        public void GetAreaValueLessZero()
        {

            double side1 = -0.5;
            double side2 = 7;
            double side3 = 9;
            Triangle triangle = new Triangle(side1, side2, side3);
        }


        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]

        public void GetAreaTwoSidesLessThird()
        {

            double side1 = 2;
            double side2 = 3;
            double side3 = 9;
            Triangle triangle = new Triangle(side1, side2, side3);
        }

        [TestMethod]

        public void CheckingRightTriangle()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

          

            Triangle triangle = new Triangle(side1, side2, side3);
            Assert.IsTrue(triangle.IsRightTriangle());

        }

        [TestMethod]

        public void CheckingNotRightTriangle()
        {
            double side1 = 14;
            double side2 = 19;
            double side3 = 22;

            bool expected = false;

            Triangle triangle = new Triangle(side1, side2, side3);
            Assert.AreEqual(expected, triangle.IsRightTriangle());
        }
    }
}
