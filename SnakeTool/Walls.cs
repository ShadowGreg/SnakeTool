namespace SnakeTool;

public class Walls
{
    private List<Figure> wallList;
    public Walls(int mapWidth, int mapHeight)
    {
        //в список базового класса добавляются наследники - полиморфизм
        wallList = new List<Figure>();
        // Отрисовка рамочки
        var upLine = new HorizontalLine(0, mapWidth-2, 0, '_');
        var downLine = new HorizontalLine(0, mapWidth-2, mapHeight-1, '-');
        var leftLine = new VerticalLine(0,mapHeight-1, 0, '|');
        var rightLine = new VerticalLine(mapWidth-2,mapHeight-1, 0, '|');

        wallList.Add(upLine);
        wallList.Add(downLine);
        wallList.Add(leftLine);
        wallList.Add(rightLine);
    }
    internal bool IsHit(Figure figure)
    {
        foreach (Figure wall in wallList)
        {
            if (wall.IsHit(figure) )
            {
                return true;
            }
        }
        return false;
    }
    public void Draw()
    {
        foreach (Figure wall in wallList)
        {
            wall.Draw();
        }
    }
}