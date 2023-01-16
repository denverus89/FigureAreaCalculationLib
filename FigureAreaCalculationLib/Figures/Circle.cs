using FigureAreaCalculationLib.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaCalculationLib.Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius {get; private set;}

        /// <summary>
        /// Конструктор создания круга
        /// </summary>
        /// <param name="radius">Радиус</param>
        internal Circle(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиус круга должен быть больше нуля");
            }

            this.Radius = radius;
        }

        /// <summary>
        /// Получение площади круга
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            double result = Math.PI * Math.Pow(Radius, 2);

            return result;
        }

    }
}
