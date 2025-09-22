
// Наследуемся от класса Shape.
// Класс Rectangle должен реализовать
// все абстрактные методы базового класса Shape.

// В данном случае это метод Draw.
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

    // Реализация абстрактного метода Draw.
    // Используется слово override,
    // т.к. мы переопределяем метод базового класса.

    // Класс Rectangle теперь реализует
    // свой вариант метода Draw.
    public override void Draw()
    {
        Console.WriteLine($"Рисую прямоугольник в {_x},{_y} размером {_width}x{_height}");
    }
}