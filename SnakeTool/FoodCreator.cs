namespace SnakeTool;

public class FoodCreator
{
    private readonly int _mapWidth;
    private readonly int _mapHeight;
    private readonly char _symbol;
    public FoodCreator(int mapWidth, int mapHeight, char symbol)
    {
        _mapWidth = mapWidth;
        _mapHeight = mapHeight;
        _symbol = symbol;
    }
    public Point CrateFood()
    {
        var rndX = new Random().Next(2, _mapWidth - 2);
        var rndY = new Random().Next(2, _mapHeight - 2);
        return new Point(rndX, rndY, _symbol);
    }
}