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
