using System;

namespace IT_Task2.Classes;

public class MyEllipse : GeometricFigure
{
    public int RadiusX { get; set; }
    public int RadiusY { get; set; }

    public MyEllipse(int centerX, int centerY, int radiusX, int radiusY) : base(centerX, centerY)
    {
        RadiusX = radiusX;
        RadiusY = radiusY;
    }

    public override (int minX, int minY, int maxX, int maxY) BoundingRectangle
    {
        get => (CenterX, CenterY, RadiusX, RadiusY);
    }

    public override float Area
    {
        get => (float)(Math.PI * RadiusX * RadiusY);
    }

    public override string Description
    {
        get => "Эллипс с радиусами  " + RadiusX + " и " + RadiusY;
    }
}