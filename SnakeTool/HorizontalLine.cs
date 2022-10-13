namespace SnakeTool;

public class HorizontalLine
{
    private List<Point> plist;

    public HorizontalLine(int xLeft, int xRight, int yHorizontal, char horizontalSymbol )
    {
        plist = new List<Point>();
        for (int x = xLeft; x <= xRight; x++)
        {
            Point p = new Point(x, yHorizontal, horizontalSymbol);
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