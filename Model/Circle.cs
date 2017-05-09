using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Figures
{
    /// <summary>
    /// Класс, описывающий круг
    /// </summary>
    public class Circle: FigureBase
    {
        double _radius;

        /// <summary>
        /// Свойство, выражающее радиус круга   
        /// </summary>
        public double Radius
        {
            set
            {
                _radius = value;
                if (_radius <= 0 || _radius > 99.999)
                    throw new ArgumentException("Было введено отрицательное или нулевое значение или значение, нахожящееся за пределом диапазона допустимых значений. Допустим ввод значений от 0.001 до 99.999");
            }

            get
            {
                return _radius;
            }
        }

        /// <summary>
        /// Нахождение площади круга
        /// </summary>
        /// <returns> Площадь круга </returns>
        public override double GetArea()
        {
            return Math.Round(3.14 * Math.Pow(_radius, 2), 2);
            //return 3.14 * _radius * _radius;
        }
    }
}
