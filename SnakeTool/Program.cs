using SnakeTool;


//устанавливаем размер буфера для не возможности его перемотки
Console.SetBufferSize(5864, 29420);
Console.Clear();
// Отрисовка рамочки
var upLine = new HorizontalLine(0, 78, 0, '+');
var downLine = new HorizontalLine(0, 78, 24, '+');
var leftLine = new VerticalLine(0, 24, 0, '+');
var rightLine = new VerticalLine(78, 24, 0, '+');
upLine.Draw();
downLine.Draw();
leftLine.Draw();
rightLine.Draw();

//Отрисовка точек
var p = new Point(4, 5, '*');
var snake = new Snake(p, 4, Direction.RIGHT);
for (int INDEX = 0; INDEX < 10; INDEX++)
{
    snake.Move();
    snake.Draw();
    Thread.Sleep(300);
}

Console.ReadKey();