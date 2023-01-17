using FigureAreaCalculationLib.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaCalculationLib.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Сторона 1
        /// </summary>
        public double Side1 { get; private set; }

        /// <summary>
        /// Сторона 2
        /// </summary>
        public double Side2 { get; private set; }

        /// <summary>
        /// Сторона 3
        /// </summary>
        public double Side3 { get; private set; }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRectangular
        {
            get
            {
                return ((Side1 * Side1 + Side2 * Side2 == Side3 * Side3) 
                    || (Side1 * Side1 + Side3 * Side3 == Side2 * Side2) 
                    || (Side3 * Side3 + Side2 * Side2 == Side1 * Side1));
            }
        }

        /// <summary>
        /// Конструктор создания треугольника
        /// </summary>
        /// <param name="side1">Сторона 1</param>
        /// <param name="side2">Сторона 2</param>
        /// <param name="side3">Сторона 3</param>
        internal Triangle(double side1, double side2, double side3)
        {
            if(side1 <= 0 || side2 <= 0 || side3 <= 0 )
            {
                throw new ArgumentOutOfRangeException("Все стороны треугольника должны быть больше 0");
            }

            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        /// <summary>
        /// Получение площади треугольника
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            //Вычисляем периметр
            double perimeter = (Side1 + Side2 + Side3);
            double halfPerimeter = perimeter / 2;

            double result = Math.Sqrt(halfPerimeter * (halfPerimeter - Side1) * (halfPerimeter - Side2) * (halfPerimeter - Side3));

            return result;
        }  
    }
}
