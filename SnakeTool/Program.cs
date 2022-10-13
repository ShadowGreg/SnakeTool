using SnakeTool;

var p1 = new Point(1, 2, '*');
p1.Draw();
var p2 = new Point(4, 5, '#');
p2.Draw();

HorizontalLine line = new HorizontalLine(5,10, 8, '+');
line.Drow();

Console.ReadKey();