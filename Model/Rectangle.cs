using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Figures
{
    /// <summary>
    /// Класс, описывыющий прямоугольник
    /// </summary>
    public class Rectangle: FigureBase
    {
        double _width;
        double _length;
        
        /// <summary>
        /// Свойство, выражающее ширину прямоугольника
        /// </summary>
        public double Width
        {
            set
            {
                _width = value;
                if (_width < 0)
                    throw new ArgumentException("Было введено отрицательное значение. Значение должно быть положительным!");
            }
            get
            {
                return _width;
            }          
        }

        /// <summary>
        /// Свойство, выражающее длину прямоугольника  
        /// </summary>
        public double Length
        {
            set
            {
                _length = value;
                if (_length < 0)
                    throw new ArgumentException("Было введено отрицательное значение. Значение должно быть положительным!");
            }
            get
            {
                return _length;
            }
        }
        
        /// <summary>
        /// Нахождение площади прямоугольника
        /// </summary>
        /// <returns> Площадь прямоугольника </returns>
        public override double GetArea()
        {
            return _length * _width;
        }
    }
}
