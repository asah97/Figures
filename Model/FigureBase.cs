using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Figures
{
    //Абстрактный класс основы фигуры
    public abstract class FigureBase: IFigure
    {
        double _startX;
        double _startY;
            
        //Инициализация координаты X начальной точки фигуры
        public double StartX
        {
            set
            {
                 _startX = value;
            }
            get
            {
                return _startX;
            }
        }

        //Инициализация координаты Y начальной точки фигуры
        public double StartY
        {
            set
            {
                _startY = value;
            }
            get
            {
                return _startY;
            }
        }

        //Абстрактный метод нахождения площади фигуры
        public abstract double GetArea();
    }
}
