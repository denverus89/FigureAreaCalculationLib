using FigureAreaCalculationLib.Common;
using FigureAreaCalculationLib.FigureFactories;
using FigureAreaCalculationLib.Figures;
using NUnit.Framework;
using System;


namespace FigureAreaCalculationLib.Tests
{
    public class TriangelInvalidDataUnitTest
    {
        

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Triangle_Check_IsRectangular()
        {            
            FigureFactory triangleFactory = new TriangleFactory(-6, 6, -8);
            Assert.Throws<ArgumentOutOfRangeException>(() => triangleFactory.Create());
        }
    }
}
