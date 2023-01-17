using FigureAreaCalculationLib.Common;
using FigureAreaCalculationLib.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaCalculationLib.FigureFactories
{
    /// <summary>
    /// Фабрика для создания круга
    /// </summary>
    public class CircleFactory : FigureFactory
    {
        private double _radius;

        /// <summary>
        /// Создание фабрики для круга
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public CircleFactory(double radius)
        {
            this._radius = radius;
        }

        /// <summary>
        /// Создание круга
        /// </summary>
        /// <returns></returns>
        public override Figure Create()
        {
            return new Circle(_radius);
        }
    }
}
