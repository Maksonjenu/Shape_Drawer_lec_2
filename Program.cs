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

        Shape rectangle = new Shape()
        {
            Type = "rectangle", // Тут мы обращаемся к каждому свойству
            X = 15,             // и задаем им значения
            Y = 20,             
            Height = 50,
            Width = 33
        };
        Shape rectangle_bad = new Shape() { Type = "Rectangle" };
        Shape circle = new Shape() { Type = "Circle" };
        Shape circle_bad = new Shape() { Type = "Cricle" };

        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(circle_bad);

        graphicEditor.DrawAllShapes(shapes);

    }
}
