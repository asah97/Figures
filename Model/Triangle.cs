using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Figures
{
    /// <summary>
    /// Класс, описывающий треугольник
    /// </summary>
    public class Triangle: FigureBase
    {
        double _sideA;

        double _sideB;

        double _sideC;

        /// <summary>
        /// Инициализация сторон треугольника
        /// </summary>
        /// <param name="a"> Первая сторона треугольника </param>
        /// <param name="b"> Вторая сторона треугольника </param>
        /// <param name="c"> Третья сторона треугольника </param>
        public void SetSides(double a, double b, double c)
        {
            if ((a < 0) || (b < 0) || (c < 0))
                throw new ArgumentException("Было введено отрицательное значение одной из трех сторон. Значение должно быть положительным!");
            else
            {
                _sideA = a;
                _sideB = b;
                _sideC = c;
            }
            if (((_sideA + _sideB) < _sideC) || ((_sideB + _sideC) < _sideA) || ((_sideA + _sideC) < _sideB))
                throw new ArgumentException("Сумма любых двух сторон треугольника должна быть больше третьей стороны");


        }
        
        /// <summary>
        /// Свойство, выражающее первую сторону треугольника
        /// </summary>
        public double SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                _sideA = value;
            }
        }

        /// <summary>
        /// Свойство, выражающее вторую сторону треугольника
        /// </summary>
        public double SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                _sideB = value;
            }
        }

        /// <summary>
        /// Свойство, выражающее третью сторону треугольника
        /// </summary>
        public double SideC
        {
            get
            {
                return _sideC;
            }
            set
            {
                _sideC = value;
            }
        }

        /// <summary>
        /// Нахождение площади треугольника
        /// </summary>
        /// <returns> Площадь треугольника </returns>
        public override double GetArea()
        {
            double halfPerim = 0.5 * (_sideA + _sideB + _sideC);

            return Math.Sqrt(halfPerim * (halfPerim - _sideA) * (halfPerim - _sideB) * (halfPerim - _sideC));
        }

    }
}
