using SnakeTool;


//устанавливаем размер буфера для не возможности его перемотки
System.Diagnostics.Process.GetCurrentProcess();
Console.SetBufferSize(27296, 4148);
Console.CursorVisible = false;
Console.Clear();
// Отрисовка рамочки
var upLine = new HorizontalLine(0, 78, 0, '_');
var downLine = new HorizontalLine(0, 78, 24, '-');
var leftLine = new VerticalLine(0, 24, 0, '|');
var rightLine = new VerticalLine(78, 24, 0, '|');
upLine.Draw();
downLine.Draw();
leftLine.Draw();
rightLine.Draw();

//Отрисовка точек
var p = new Point(4, 5, '*');
var snake = new Snake(p, 4, Direction.RIGHT);
snake.Draw();

//Отрисовка еды
var foodCreator = new FoodCreator(80, 25, '$');
Point food = foodCreator.CrateFood();
food.Draw();

while (true)
{
    if (snake.Eat(food))
    {
        food = foodCreator.CrateFood();
        food.Draw();
    }
    else
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            snake.HandleKey(key.Key);
        }
        snake.Move();
    }

    Thread.Sleep(100);
}