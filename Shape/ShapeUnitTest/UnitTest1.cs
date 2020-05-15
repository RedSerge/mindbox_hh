using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeArea;
using System;

namespace ShapeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidShapeException), "Wrong triangle was inappropriately allowed.")]
        public void TestWrongTriangle1()
        {
            new Triangle(-1, 2, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidShapeException), "Wrong triangle was inappropriately allowed.")]
        public void TestWrongTriangle2()
        {
            new Triangle(1, -2, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidShapeException), "Wrong triangle was inappropriately allowed.")]
        public void TestWrongTriangle3()
        {
            new Triangle(1, 2, -3);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidShapeException), "Wrong triangle was inappropriately allowed.")]
        public void TestWrongTriangle4()
        {
            new Triangle(1, 2, 0);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidShapeException), "Wrong circle radius was inappropriately allowed.")]
        public void TestWrongCircle1()
        {
            new Circle(-1);
        }
        [TestMethod]
        public void TestALittleBitTooRightCircle()
        {
            var correct_area = 1.0;
            Assert.IsTrue(Math.Abs(new Circle(1 / Math.Sqrt(Math.PI)).Area() - correct_area) < Shape.double_threshold);
        }
        [TestMethod]
        public void TestALittleBitTooRightTriangle()
        {
            var correct_area = 0.75;
            var side = Math.Sqrt(Math.Sqrt(3.0));
            Assert.IsTrue(Math.Abs(new Triangle(side, side, side).Area() - correct_area) < Shape.double_threshold);
        }
    }
}
