public class GraphicEditor
{

    //Метод для отрисовки всех фигур из списка
    public void DrawAllShapes(List<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            //Проверяем тип создаваемой фигуры
            //Тип в виде строки 
            if (shape.Type == "rectangle")
            {
                Console.WriteLine($"Рисую прямоугольник в {shape.X},{shape.Y} размером {shape.Width}x{shape.Height}");
            }
            else if (shape.Type == "circle")
            {
                Console.WriteLine($"Рисую круг в {shape.X},{shape.Y} радиусом {shape.Radius}");
            }
            else if (shape.Type == "Любой другой тип")
            {
                Console.WriteLine($"Рисую еще что-то");
            }

        }
    }
}