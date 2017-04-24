using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Figures
{
    //Класс "круг"
    public class Circle: FigureBase
    {
        double _radius;

        //Инициализация радиуса круга   
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

        //Нахождение площади круга
        public override double GetArea()
        {
            return 3.14 * Math.Pow(_radius, 2);
        }
    }
}
