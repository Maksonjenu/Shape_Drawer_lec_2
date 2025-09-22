namespace Shape_Drawer_lec_2;

class Program
{
    static void Main(string[] args)
    {
        GraphicEditor graphicEditor = new GraphicEditor();

        List<object> shapes = new List<object>();

        // Теперь наш список фигур имеет базовый тип 
        // object. В данный список можно добавлять объекты
        // других типов, это небезопасно.

        // Также мы создаем наши переменные как объекты
        // созданных нами классов
        Rectangle rectangle = new Rectangle(15, 20, 33, 50);
        Rectangle rectangle_bad = new Rectangle(0, 0, 0, 0);
        Circle circle = new Circle(0, 0, 10);
        Circle circle_bad = new Circle(0, 0, 0);

        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(circle_bad);

        graphicEditor.DrawAllShapes(shapes);

    }
}
