public class GraphicEditor
{

    //Метод для отрисовки всех фигур из списка
    // Сигнатура метода изменилась, теперь аргументом
    // является список "объектов"
    public void DrawAllShapes(List<object> shapes)
    {
        foreach (var shape in shapes)
        {
            // С помощью оператора is мы проверяем
            // допустимость преобразования shape
            // в нужный нам тип, и если это возможно
            // преобразование сохраняется в rect
            if (shape is Rectangle rect)
            {
                rect.Draw();
            }

            // Аналогично коду выше, только
            // с классом окружности

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