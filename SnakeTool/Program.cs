using SnakeTool;


//устанавливаем размер буфера для не возможности его перемотки
Console.SetBufferSize(5864, 29420);
var p1 = new Point(1, 2, '*');
p1.Draw();
var p2 = new Point(4, 5, '#');
p2.Draw();

var upLine = new HorizontalLine(0, 78, 0, '+');
var downLine = new HorizontalLine(0, 78, 24, '+');
var leftLine = new VerticalLine(0, 24, 0, '+');
var rightLine = new VerticalLine(78, 24, 0, '+');
upLine.Draw();
downLine.Draw();
leftLine.Draw();
rightLine.Draw();

Console.ReadKey();