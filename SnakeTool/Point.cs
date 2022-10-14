namespace SnakeTool;

/*
 инкапсуляция метод позволяющий объединить в себе
 данные и методы работающие в классе и скрыть все детали реализации от пользователя
 */
public class Point
{
    public int x;
    public int y;
    public char symbol;

    public Point(int _x, int _y, char _symbol)
    {
        this.x = _x;
        this.y = _y;
        this.symbol = _symbol;
    }

    public Point(Point inPoint)
    {
        x = inPoint.x;
        y = inPoint.y;
        symbol = inPoint.symbol;
    }

    public void PointMove(int offset, Direction direction)
    {
        if (direction == Direction.RIGHT)
        {
            x = x + offset;
        }
        else if (direction == Direction.LEFT)
        {
            x = x - offset;
        }
        else if (direction == Direction.UP)
        {
            y = y - offset;
        }
        else if (direction == Direction.DOWN)
        {
            y = y + offset;
        }
    }

    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }
    public override string ToString()
    {
        return x + ", " + y + ", " + symbol;
    }
    public void Clear()
    {
        symbol = ' ';
        Draw();
    }
    public bool IsHit(Point food)
    {
        return food.x == this.x && food.y == this.y;
    }
}