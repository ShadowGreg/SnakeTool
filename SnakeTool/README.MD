# 3 Принципа ООП

1. Инкапсуляция - механизм который объединяет данные и код который манипулирует этими данными, а так же защищает и то и
   другое от внешнего вмешательства и не правильного использования.
   Мы создавали классы например точка:

```csharp
public class Point
{
// поля класса (состояния, переменные)
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
```

На базе этого класса можно создавать сколько угодно экземпляров например:

```csharp
var p = new Point(4, 5, '*');
```

или

```csharp
var foodCreator = new FoodCreator(80, 25, '$');
Point food = foodCreator.CrateFood();
```

В FoodCreator поля которые не доступны за пределами класса помечены как _private_

```csharp
public class FoodCreator
{
    private readonly int _mapWidth;
    private readonly int _mapHeight;
    private readonly char _symbol;
```

Пользователь может использовать только то что явно разрешено, а класс и его методы представляют собой некий черный ящик

2. Наследование - позволяет создавать новые классы которые наследуют, расширяют и изменяют поведение определенное в других классах
Пример:
```csharp
public class Figure
{
    protected List<Point> pList;
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
```
и написали ещё несколько классов которые расширяют и используют поведение Figure
```csharp
public class Snake: Figure
{
    private Direction _direction;
    .
    .
    .
    
```
и 
```csharp
public class HorizontalLine: Figure
{
    public HorizontalLine(int xLeft, int xRight, int yHorizontal, char horizontalSymbol)
    {
        pList = new List<Point>();
        for (var x = xLeft; x <= xRight; x++)
        {
            var p = new Point(x, yHorizontal, horizontalSymbol);
            pList.Add(p);
        }
    }
    /*
     * полиморфизм
     */
    public override void Draw()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        //можем заимствовать метод из базового класса 
        base.Draw();
        /*
         переписанный метод мог бы выглядеть так 
            foreach (Point variable in pList)
            {
                variable.Draw();
            }
        */
        Console.ForegroundColor = ConsoleColor.White;
    }
}
```
3. Полиморфизм - способность функции обрабатывать данные разных типов. Параметрический полиморфизм является истинным, т.к. подразумевает исполнение одного и того же кода для всех допустимых типов аргументов, а ad-hoc-полиморфизм — мнимым, т.к. представляет собой обеспечение косметической однородности потенциально разного исполнимого кода для каждого конкретного типа аргумента
```csharp
public class Point
{
    public int x;
    public int y;
    public char symbol;
    .
    .
    .
    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }
    .
    .
    .
    
 public class HorizontalLine: Figure   
    public override void Draw()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        //можем заимствовать метод из базового класса 
        base.Draw();
        /*
         переписанный метод мог бы выглядеть так 
            foreach (Point variable in pList)
            {
                variable.Draw();
            }
        */
        Console.ForegroundColor = ConsoleColor.White;
    }
``` 
так же полиморфизм позволяет переопределять в классах наследниках поведение функций
```csharp
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
}
```
и
```csharp
public class HorizontalLine: Figure
{
    public override void Draw()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        //можем заимствовать метод из базового класса 
        base.Draw();
        /*
         переписанный метод мог бы выглядеть так 
            foreach (Point variable in pList)
            {
                variable.Draw();
            }
        */
        Console.ForegroundColor = ConsoleColor.White;
    }
}
```