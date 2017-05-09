using System;

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
                if (_width <= 0 || _width > 99.999)
                    throw new ArgumentException("Было введено отрицательное или нулевое значение или значение, нахожящееся за пределом диапазона допустимых значений. Допустим ввод значений от 0.001 до 99.999");
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
                if (_length <= 0 || _length > 99.999)
                    throw new ArgumentException("Было введено отрицательное или нулевое значение или значение, нахожящееся за пределом диапазона допустимых значений. Допустим ввод значений от 0.001 до 99.999");
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
            return Math.Round(_length * _width, 2);
        }
    }
}
