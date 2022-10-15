namespace SnakeTool;

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
/*
 * Метод описан в двух классах одинаково
 * так что мы возьмем наследование - что бы можно было полностью или частично переиспользовать методы класса
 * Draw() в новый класс фигуры
 */
}