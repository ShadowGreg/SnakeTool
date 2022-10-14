namespace SnakeTool;

/*
 * абстрагирование это прием позволяющий выделить набор значимых характеристики исключая не значимые
 */
public class Snake: Figure
{
    private Direction _direction;
    public Snake(Point tail, int lenght, Direction direction)
    {
        _direction = direction;
        pList = new List<Point>();
        for (var i = 0; i < lenght; i++)
        {
            var p = new Point(tail);
            p.PointMove(i, _direction);
            pList.Add(p);
        }
    }
    public void Move()
    {
        Point tail = pList.First();
        pList.Remove(tail);
        Point head = GetNextPoint();
        pList.Add(head);

        tail.Clear();
        head.Draw();
    }
    private Point GetNextPoint()
    {
        Point head = pList.Last();
        var nextPoint = new Point(head);
        nextPoint.PointMove(1, _direction);
        return nextPoint;
    }

    public void HandleKey(ConsoleKey key)
    {
        while (true)
        {
            _direction = key switch
            {
                ConsoleKey.LeftArrow => Direction.LEFT,
                ConsoleKey.RightArrow => Direction.RIGHT,
                ConsoleKey.DownArrow => Direction.DOWN,
                ConsoleKey.UpArrow => Direction.UP,
                _ => _direction
            };
        }
    }
}