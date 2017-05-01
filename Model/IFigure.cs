using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Figures
{
    /// <summary>
    /// Интерфейс фигуры
    /// </summary>
    public interface IFigure
    {
        double StartX { get; set; }
        double StartY { get; set; }
        double GetArea();
    }
}
