using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Figures
{
    //Класс "треугольник"
    public class Triangle: FigureBase
    {
        double _sideA;

        double _sideB;

        double _sideC;

        //Метод, инициализирующий стороны треугольника
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

        //Нахождение площади треугольника по формуле Герона
        public override double GetArea()
        {
            double halfPerim = 0.5 * (_sideA + _sideB + _sideC);

            return Math.Sqrt(halfPerim * (halfPerim - _sideA) * (halfPerim - _sideB) * (halfPerim - _sideC));
        }

    }
}
