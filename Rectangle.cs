
// Наследуемся от класса Shape
public class Rectangle : Shape
{

    // Поля, специфичные для прямоугольника
    private int _width, _height;

    public Rectangle(int x, int y, int width, int height)
    {

        // Поля _x и _y теперь принадлежат базовому классу Shape,
        // поэтому мы можем к ним обращаться напрямую
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