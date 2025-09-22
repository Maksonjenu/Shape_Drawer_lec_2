public class Rectangle
{
    private int _x, _y, _width, _height;

    public Rectangle(int x, int y, int width, int height)
    {
        _x = x;
        _y = y;
        _width = width;
        _height = height;
    }

    public void Draw()
    {
        Console.WriteLine($"Рисую прямоугольник в {_x},{_y} размером {_width}x{_height}");
    }
}