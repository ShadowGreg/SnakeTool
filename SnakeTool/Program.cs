using SnakeTool;

var p1 = new Point(1, 2, '*');
p1.Draw();
var p2 = new Point(4, 5, '#');
p2.Draw();
Console.ReadKey();

List<int> numList = new List<int>
{
    0,
    1,
    2
};

List<Point> pList = new List<Point>
{
    p1,
    p2
};