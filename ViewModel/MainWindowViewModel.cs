using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IT_Task2.Classes;

namespace IT_Task2.ViewModel;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] private int _lineX1;
    [ObservableProperty] private int _lineY1;
    [ObservableProperty] private int _lineX2;
    [ObservableProperty] private int _lineY2;

    [ObservableProperty] private int _pointX;
    [ObservableProperty] private int _pointY;

    [ObservableProperty] private int _ellipseX;
    [ObservableProperty] private int _ellipseY;
    [ObservableProperty] private int _ellipseRX;
    [ObservableProperty] private int _ellipseRY;

    [ObservableProperty] private int _rectangleX;
    [ObservableProperty] private int _rectangleY;
    [ObservableProperty] private int _rectangleW;
    [ObservableProperty] private int _rectangleH;

    [ObservableProperty] ObservableCollection<GeometricFigure> _figures = new(){new MyEllipse(0,0, 1, 2), new MyRectangle(10, 10, 20, 40)};


    [RelayCommand]
    public void AddEllipse()
    {
        if (EllipseRX <= 0 || EllipseRY <= 0) return;
        Figures.Add(new MyEllipse(EllipseX, EllipseY, EllipseRX, EllipseRY));
    }

    [RelayCommand]
    public void AddLine()
    {
        Figures.Add(new MyLine(LineX1, LineY1, LineX2, LineY2));
    }

    [RelayCommand]
    public void AddPoint()
    {
        Figures.Add(new MyPoint(PointX, PointY));
        PointX = 0; 
        PointY = 0;
    }

    [RelayCommand]
    public void AddRectangle()
    {
        if (RectangleH <= 0 || RectangleW <= 0) return;
        Figures.Add(new MyRectangle(RectangleX, RectangleY, RectangleW, RectangleH));
    }
}