public class Shape
{

    #region Общие поля

    //Для хранения типа мы сейчас специально используем "опасную" строку
    public string Type { get; set; }

    //Х и У тут хранить можно
    public int X { get; set; }
    public int Y { get; set; }

    #endregion

    //А вот эти переменные мы смешали в кучу
    //Их нужно будет разделить с поомщью инкапсулияции
    //Радиус - для круга
    // Высота и ширина для прямоугольника
    public int Radius { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
}