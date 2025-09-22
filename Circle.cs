public class Circle : Shape
{
    private int _radius;

    public Circle(int x, int y, int radius)
    {
        _x = x;
        _y = y;
        _radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Рисую круг в {_x},{_y} радиусом {_radius}");
    }

}