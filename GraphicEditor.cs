public class GraphicEditor
{

    // Метод DrawAllShapes теперь принимает список фигур типа Shape
    public void DrawAllShapes(List<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            // Вызываем метод Draw для каждой фигуры.
            // Какой именно метод Draw будет вызван
            // (из Circle или из Rectangle) - зависит от типа объекта,
            // на который указывает переменная shape.

            //Благодаря тому, что метод Draw объявлен как абстрактный
            //в базовом классе Shape, компилятор "знает", что у каждого
            //класса-наследника (Circle, Rectangle) есть своя реализация метода Draw.

            shape.Draw();
        }
    }
}