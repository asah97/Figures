using System;

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
            if ((a <= 0) || (b <= 0) || (c <= 0))
                throw new ArgumentException("Было введено отрицательное или нулевое значение одной из трех сторон. Значение должно быть положительным!");
            if ((a > 99.999) || (b > 99.999) || (c > 99.999))
                throw new ArgumentException("Было введено значение одной из сторон, находящееся за пределом допустимых");
            if (((a + b) < c) || ((b + c) < a) || ((a + c) < b))
                throw new ArgumentException("Сумма любых двух сторон треугольника должна быть больше третьей стороны");
            {
                _sideA = a;
                _sideB = b;
                _sideC = c;
            }
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
                if (_sideA <= 0 || _sideA > 99.999)
                    throw new ArgumentException("Было введено отрицательное или нулевое значение или значение, нахожящееся за пределом диапазона допустимых значений. Допустим ввод значений от 0.001 до 99.999");
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
               if (_sideB <= 0 || _sideB > 99.999)
                    throw new ArgumentException("Было введено отрицательное или нулевое значение или значение, нахожящееся за пределом диапазона допустимых значений. Допустим ввод значений от 0.001 до 99.999");
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
                if (_sideC <= 0 || _sideC > 99.999)
                    throw new ArgumentException("Было введено отрицательное или нулевое значение или значение, нахожящееся за пределом диапазона допустимых значений. Допустим ввод значений от 0.001 до 99.999");
            }
        }

        /// <summary>
        /// Нахождение площади треугольника
        /// </summary>
        /// <returns> Площадь треугольника </returns>
        public override double GetArea()
        {
            double halfPerim = 0.5 * (_sideA + _sideB + _sideC);

            return Math.Round(Math.Sqrt(halfPerim * (halfPerim - _sideA) * (halfPerim - _sideB) * (halfPerim - _sideC)), 2);
        }

    }
}
