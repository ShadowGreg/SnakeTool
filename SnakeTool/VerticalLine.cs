namespace SnakeTool;

public class VerticalLine: Figure
{
    public VerticalLine(int xVertical, int yHigher, int yBelow, char verticalSymbol)
    {
        pList = new List<Point>();
        for (var y = yBelow; y <= yHigher; y++)
        {
            var p = new Point(xVertical, y, verticalSymbol);
            pList.Add(p);
        }
    }
}