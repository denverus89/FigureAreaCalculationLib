using FigureAreaCalculationLib.Common;
using FigureAreaCalculationLib.FigureFactories;
using NUnit.Framework;
using System;

namespace FigureAreaCalculationLib.Tests
{
    /// <summary>
    /// Тест круга
    /// </summary>
    public class CircleAreaUnitTest
    {
        Figure circle;

        [SetUp]
        public void Setup()
        {
            FigureFactory circleFactory = new CircleFactory(5);
            circle = circleFactory.Create();
        }

        /// <summary>
        /// Тест вычисления площади круга
        /// </summary>
        [Test]
        public void Circle_Check_GetArea()
        {
            double area = circle.GetArea();
            Assert.AreEqual(78.54d, Math.Round(area, 2));
        }      
    }
}