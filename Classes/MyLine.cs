using System;

namespace IT_Task2.Classes;

public class MyLine : GeometricFigure
{
    public int StartX { get; set; }
    public int StartY { get; set; }
    public int EndX { get; set; }
    
    public int EndY { get; set; }

    public MyLine(int startX, int startY, int endX, int endY) : base((startX + endX) / 2, (startY + endY) / 2) {
        StartX = startX;
        StartY = startY;
        EndX = endX;
        EndY = endY;
    }

    public override (int minX, int minY, int maxX, int maxY) BoundingRectangle
    {
        get
        {
            int minX = Math.Min(CenterX, EndX);
            int minY = Math.Min(CenterY, EndY);
            int maxX = Math.Max(CenterX, EndX);
            int maxY = Math.Max(CenterY, EndY);
            return (minX, minY, maxX, maxY);
        }
    }

    public override float Area
    {
        get => 0; // Площадь линии равна 0
    }

    public override string Description
    {
        get => $"Линия, идущая из ({StartX}; {StartY}) в ({EndX}; {EndY})";
    }
}
