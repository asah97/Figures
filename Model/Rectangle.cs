using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Figures
{
    //Класс "Прямоугольник"
    public class Rectangle: FigureBase
    {
        double _width;
        double _length;
        
        //Инициализация ширины прямоугольника                        
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

        

        //Инициализация длины прямоугольника        
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
        
        //Нахождение площади прямоугольника         
        public override double GetArea()
        {
            return _length * _width;
        }

    }
          
}
