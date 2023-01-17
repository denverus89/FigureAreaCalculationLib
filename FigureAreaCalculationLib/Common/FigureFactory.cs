using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaCalculationLib.Common
{
    /// <summary>
    /// Фабрика создания фигур
    /// </summary>
    public abstract class FigureFactory
    {
        /// <summary>
        /// Создание фигуры
        /// </summary>
        /// <returns></returns>
        public abstract Figure Create();
    }
}
