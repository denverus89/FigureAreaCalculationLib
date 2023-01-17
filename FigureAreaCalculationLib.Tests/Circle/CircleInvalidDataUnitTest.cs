using FigureAreaCalculationLib.Common;
using FigureAreaCalculationLib.FigureFactories;
using NUnit.Framework;
using System;

namespace FigureAreaCalculationLib.Tests
{
    /// <summary>
    /// Тест круга
    /// </summary>
    public class CircleInvalidDataUnitTest
    { 
        [SetUp]
        public void Setup()
        {

        }

        /// <summary>
        /// Тест на некорректные входящие данные
        /// </summary>
        [Test]
        public void Circle_Check_Invalid_Input_Data()
        {
            FigureFactory circleFactory = new CircleFactory(-3);
             Assert.Throws<ArgumentOutOfRangeException>(() => circleFactory.Create());
        }
    }
}