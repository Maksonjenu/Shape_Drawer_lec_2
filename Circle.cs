// Наследуемся от класса Shape.
// Класс Circle должен реализовать
// все абстрактные методы базового класса Shape.

// В данном случае это метод Draw.
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

    // Реализация абстрактного метода Draw.
    // Используется слово override,
    // т.к. мы переопределяем метод базового класса.

    // Класс Circle теперь реализует
    // свой вариант метода Draw.
    public override void Draw()
    {
        Console.WriteLine($"Рисую круг в {_x},{_y} радиусом {_radius}");
    }

}