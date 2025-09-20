namespace Shape_Drawer_lec_2;

class Program
{
    static void Main(string[] args)
    {
        GraphicEditor graphicEditor = new GraphicEditor();

        List<object> shapes = new List<object>();

        //Использование типов как строк требует 
        //большого внимания к написанию
        //я сам пока делал пример забыл, что в методе-рисовальщике 
        //я написал типы с маленькой буквы :)

        //TODO: Изменить инициализацию переменных
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
