//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Newtonsoft.Json;

namespace Figures
{
    /// <summary>
    /// Абстрактный класс основы фигуры
    /// </summary>
    public abstract class FigureBase: IFigure
    {
        double _startX;
        double _startY;

        /// <summary>
        /// Инициализация координаты X начальной точки
        /// </summary>    
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

        /// <summary>
        /// Инициализация координаты Y начальной точки
        /// </summary>
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

        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns> Площадь фигуры. </returns>
        public abstract double GetArea();
    }
}
