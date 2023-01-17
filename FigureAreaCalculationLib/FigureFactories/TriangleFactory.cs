using FigureAreaCalculationLib.Common;
using FigureAreaCalculationLib.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaCalculationLib.FigureFactories
{
    /// <summary>
    /// Фабрика для создания треугольника
    /// </summary>
    public class TriangleFactory : FigureFactory
    {
        private double _side1;
        private double _side2;
        private double _side3;

        /// <summary>
        /// Создание фабрики для треугольника
        /// </summary>
        /// <param name="side1">Сторона 1</param>
        /// <param name="side2">Сторона 2</param>
        /// <param name="side3">Сторона 3</param>
        public TriangleFactory(double side1, double side2, double side3)
        {
            this._side1 = side1;
            this._side2 = side2;
            this._side3 = side3;
        }

        /// <summary>
        /// Создание треугольника
        /// </summary>
        /// <returns></returns>
        public override Figure Create()
        {
            return new Triangle(_side1, _side2, _side3);
        }
    }
}
