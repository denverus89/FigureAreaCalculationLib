using FigureAreaCalculationLib.Common;
using FigureAreaCalculationLib.FigureFactories;
using NUnit.Framework;
using System;

namespace FigureAreaCalculationLib.Tests
{
    public class CircleInvalidDataUnitTest
    { 
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Circle_Check_Invalid_Input_Data()
        {
            FigureFactory circleFactory = new CircleFactory(-3);
             Assert.Throws<ArgumentOutOfRangeException>(() => circleFactory.Create());
        }
    }
}