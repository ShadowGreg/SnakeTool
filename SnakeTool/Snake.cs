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
        if (key == ConsoleKey.LeftArrow)
            _direction = Direction.LEFT;
        else if (key == ConsoleKey.RightArrow)
            _direction = Direction.RIGHT;
        else if (key == ConsoleKey.DownArrow)
            _direction = Direction.DOWN;
        else if (key == ConsoleKey.UpArrow)
            _direction = Direction.UP;
    }
    public bool Eat(Point food)
    {
        Point head = GetNextPoint();
        if (head.IsHit(food))
        {
            food.symbol = head.symbol;
            pList.Add(food);
            return true;
        }

        return false;
    }
    internal bool IsHitTail()
    {
        var head = pList.Last();
        for (int i = 0; i < pList.Count-2; i++)
        {
            if (head.IsHit(pList[i]))
            {
                return true;
            }
        }
        return false;
    }
}