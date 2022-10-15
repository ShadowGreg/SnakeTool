using SnakeTool;


//устанавливаем размер буфера для не возможности его перемотки
System.Diagnostics.Process.GetCurrentProcess();
Console.SetBufferSize(27296, 4148);
Console.CursorVisible = false;
Console.Clear();
Walls walls = new Walls(80, 25);
walls.Draw();


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
    if (walls.IsHit(snake) || snake.IsHitTail())
    {
        break;
    }

    if (snake.Eat(food))
    {
        food = foodCreator.CrateFood();
        food.Draw();
    }
    else
    {
        snake.Move();
    }

    Thread.Sleep(100);
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        snake.HandleKey(key.Key);
    }
}