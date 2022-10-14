namespace SnakeTool;
/*
 * абстрагирование это прием позволяющий выделить набор значимых характеристики исключая не значимые
 */
public class Snake: Figure
{
    public Snake(Point tail, int lenght, Direction direction)
    {
        plist = new List<Point>();
        for (int i = 0; i < lenght; i++)
        {
            var p = new Point(tail);
            p.Move(i, direction);
            plist.Add(p);
        }
    }
}