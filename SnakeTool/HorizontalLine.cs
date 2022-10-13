namespace SnakeTool;

public class HorizontalLine: Figure
{
    public HorizontalLine(int xLeft, int xRight, int yHorizontal, char horizontalSymbol)
    {
        plist = new List<Point>();
        for (var x = xLeft; x <= xRight; x++)
        {
            var p = new Point(x, yHorizontal, horizontalSymbol);
            plist.Add(p);
        }
    }
/*
 * Метод описан в двух классах одинаково
 * так что мы возьмем наследование - что бы можно было полностью или частично переиспользовать методы класса
 * Draw() в новый класс фигуры
 */
}