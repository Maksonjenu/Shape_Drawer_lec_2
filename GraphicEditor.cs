public class GraphicEditor
{

    public void DrawAllShapes(List<Shape> shapes)
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