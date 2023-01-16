using FigureAreaCalculationLib.Common;
using FigureAreaCalculationLib.FigureFactories;
using FigureAreaCalculationLib.Figures;
using NUnit.Framework;
using System;


namespace FigureAreaCalculationLib.Tests
{
    public class TriangleAreaAndRectangularUnitTest
    {
        Figure triangle;

        [SetUp]
        public void Setup()
        {
            FigureFactory triangleFactory = new TriangleFactory(10, 15, 20);
            triangle = triangleFactory.Create();
        }

        [Test]
        public void Triangle_Check_GetArea()
        {
            double area = triangle.GetArea();
            Assert.AreEqual(72.62d, Math.Round(area, 2));
        }

        [Test]
        public void Triangle_Check_IsRectangular()
        {
            Triangle triangleObj = triangle as Triangle;
            Assert.IsFalse(triangleObj.IsRectangular);
        }
    }
}
