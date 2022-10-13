namespace SnakeTool;

public class VerticalLine
{
    private List<Point> plist;

    public VerticalLine(int xVertical, int yHigher, int yBelow,  char verticalSymbol )
    {
        plist = new List<Point>();
        for (int y = yBelow; y <= yHigher; y++)
        {
            Point p = new Point(xVertical, y, verticalSymbol);
            plist.Add(p);
        }
    }

    public void Drow()
    {
        foreach (Point VARIABLE in plist)
        {
            VARIABLE.Draw();
        }
    }
}