namespace SnakeTool;

/// <summary>
/// Базовый класс для своих наследников вертикальной и горизонтальной линии
/// </summary>
public class Figure
{
    protected List<Point> pList;
    //полиморфизм функция принимает фигуру
    public virtual void Draw()
    {
        foreach (Point VARIABLE in pList)
        {
            VARIABLE.Draw();
        }
    }
    public bool IsHit(Figure figure)
    {
        foreach (Point point in pList)
        {
            if (figure.IsHit(point))
            {
                return true;
            }
        }

        return false;
    }
    //полиморфизм функция принимает точку
    private bool IsHit(Point inPoint)
    {
        foreach (Point point in pList)
        {
            if (point.IsHit(inPoint))
            {
                return true;
            }
        }

        return false;
    }
}