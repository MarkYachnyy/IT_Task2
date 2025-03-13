namespace IT_Task2.Classes;

public abstract class GeometricFigure
{
    public int CenterX { get; set; }
    public int CenterY { get; set; }

    protected GeometricFigure(){}
    
    protected GeometricFigure(int centerX, int centerY)
    {
        CenterX = centerX;
        CenterY = centerY;
    }

    public abstract (int minX, int minY, int maxX, int maxY) BoundingRectangle { get; }
    public abstract float Area { get; }
    
    public abstract string Description { get; }
}