namespace Shape_Drawer_lec_2;

class Program
{
    static void Main(string[] args)
    {
        GraphicEditor graphicEditor = new GraphicEditor();

        // Возвращаем тип данных Shape в словарь
        // Теперь мы можем создавать список фигур
        // и добавлять туда только объекты классов-наследников

        List<Shape> shapes = new List<Shape>();

        //Объявление конкретных фигур осталось без изменений
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
