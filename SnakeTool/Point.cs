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

    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }
}