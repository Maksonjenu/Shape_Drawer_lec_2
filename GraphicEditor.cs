public class GraphicEditor
{

    //Метод для отрисовки всех фигур из списка
    public void DrawAllShapes(List<object> shapes)
    {
        foreach (var shape in shapes)
        {
            if (shape is Rectangle rect)
            {
                rect.Draw();
            }
            else if (shape is Circle circle)
            {
                circle.Draw();
            }
            else
            {
                throw new Exception("Неизвестная фигура");
            }
        }
    }
}