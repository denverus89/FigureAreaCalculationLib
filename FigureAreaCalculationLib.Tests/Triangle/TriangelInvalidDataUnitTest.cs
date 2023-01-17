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
    public class TriangelInvalidDataUnitTest
    {
        

        [SetUp]
        public void Setup()
        {
            
        }

        /// <summary>
        /// Тест на некорректные входящие данные
        /// </summary>
        [Test]
        public void Triangle_Check_IsRectangular()
        {            
            FigureFactory triangleFactory = new TriangleFactory(-6, 6, -8);
            Assert.Throws<ArgumentOutOfRangeException>(() => triangleFactory.Create());
        }
    }
}
