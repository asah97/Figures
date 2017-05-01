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
                if (_radius < 0)
                    throw new ArgumentException("Было введено отрицательное значение. Значение должно быть положительным!");
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
        }
    }
}
