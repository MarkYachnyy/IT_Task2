namespace IT_Task2.Classes;

public class MyRectangle : GeometricFigure
{
    public int Width { get; set; }
    public int Height { get; set; }

    public MyRectangle(int centerX, int centerY, int width, int height) : base(centerX, centerY)
    {
        Width = width;
        Height = height;
    }

    public override (int minX, int minY, int maxX, int maxY) BoundingRectangle
    {
        get
        {
            int minX = CenterX - Width / 2;
            int minY = CenterY - Height / 2;
            int maxX = CenterX + Width / 2;
            int maxY = CenterY + Height / 2;
            return (minX, minY, maxX, maxY);
        }
    }

    public override float Area
    {
        get => Width * Height;
    }

    public override string Description { get => $"Прямоугольник шириной {Width} и высотой {Height}";}
}