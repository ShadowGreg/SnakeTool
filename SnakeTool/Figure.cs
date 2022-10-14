namespace SnakeTool;
/// <summary>
/// Базовый класс для своих наследников вертикальной и горизонтальной линии
/// </summary>
public class Figure
{
    protected List<Point> pList;
    public void Draw()
    {
        foreach (Point VARIABLE in pList)
        {
            VARIABLE.Draw();
        }
    }
}