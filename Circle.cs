// Наследуемся от класса Shape
public class Circle : Shape
{
    // Поля, специфичные для круга
    private int _radius;

    public Circle(int x, int y, int radius)
    {
        // Поля _x и _y теперь принадлежат базовому классу Shape,
        // поэтому мы можем к ним обращаться напрямую
        _x = x;
        _y = y;
        _radius = radius;
    }

    public void Draw()
    {
        Console.WriteLine($"Рисую круг в {_x},{_y} радиусом {_radius}");
    }

}