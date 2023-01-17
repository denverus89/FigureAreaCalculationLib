using FigureAreaCalculationLib.Common;
using FigureAreaCalculationLib.FigureFactories;
using FigureAreaCalculationLib.Figures;
using NUnit.Framework;
using System;


namespace FigureAreaCalculationLib.Tests
{
    /// <summary>
    /// Тест треугольника
    /// </summary>
    public class TriangleRectangularUnitTest
    {
        Figure triangle;

        [SetUp]
        public void Setup()
        {
            FigureFactory triangleFactory = new TriangleFactory(2.8d, 2.1d, 3.5);
            triangle = triangleFactory.Create();
        }

        /// <summary>
        /// Тест вычисления: является ли треугольник прямоугольным (TRUE)
        /// </summary>
        [Test]
        public void Triangle_Check_IsRectangular()
        {
            Triangle triangleObj = triangle as Triangle;
            Assert.IsTrue(triangleObj.IsRectangular);
        }
    }
}
