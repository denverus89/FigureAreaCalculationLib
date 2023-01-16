using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaCalculationLib.Common
{
    /// <summary>
    /// Абстрактный класс фигуры
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Получение площади фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();
    }
}
