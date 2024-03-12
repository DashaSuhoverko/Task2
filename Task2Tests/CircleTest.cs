using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Task2Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]

        public void GetArea_WithPositiveValue()
        {
            // arrange
            double radius =5;
            Circle circle = new Circle(radius);
           
            double expected = 78.53981633974483;

            // act
            double actual = circle.GetArea();

            // assert
            Assert.AreEqual(expected, actual);

        }

        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
      

        public void GetArea_WithZero()
        {
           
            double radius = 0;
            Circle circle = new Circle(radius);

         }

        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void GetAreaValueLessZero()
        {
            double radius = -1;
            Circle circle = new Circle(radius);


        }
    }
}
