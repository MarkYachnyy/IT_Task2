namespace IT_Task2.Classes;

public class MyPoint : GeometricFigure
{
    public MyPoint(int x, int y) : base(x, y) { }

    public override (int minX, int minY, int maxX, int maxY) BoundingRectangle
    {
        get => (CenterX, CenterY, CenterX, CenterY);
    }
    
    
    public override float Area
    {
        get => 0;
    }

    public override string Description { get => "Точка"; }
}