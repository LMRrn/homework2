using System;

// 定义矩形类Rect
class Rect
{
    // 属性
    public double Width { get; set; }
    public double Height { get; set; }

    // 构造方法
    public Rect(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public Rect()
    {
        Width = 10;
        Height = 10;
    }

    // 方法
    public double Area()
    {
        return Width * Height;
    }

    public double Perimeter()
    {
        return 2 * (Width + Height);
    }
}

// 定义具有确定位置的矩形类PlainRect，继承自Rect
class PlainRect : Rect
{
    // 属性
    public double StartX { get; set; }
    public double StartY { get; set; }

    // 构造方法
    public PlainRect(double startX, double startY, double width, double height) : base(width, height)
    {
        StartX = startX;
        StartY = startY;
    }

    public PlainRect() : base()
    {
        StartX = 0;
        StartY = 0;
    }

    // 方法
    public bool IsInside(double x, double y)
    {
        return x >= StartX && x <= StartX + Width && y >= StartY && y <= StartY + Height;
    }
}

class Program
{
    static void Main()
    {
        // 创建一个左上角坐标为（10，10），长为20，宽为10的矩形对象
        PlainRect rect = new PlainRect(10, 10, 20, 10);

        // 计算并打印输出矩形的面积和周长
        Console.WriteLine($"矩形的面积为：{rect.Area()}");
        Console.WriteLine($"矩形的周长为：{rect.Perimeter()}");

        // 判断点(25.5，13)是否在矩形内，并打印输出相关信息
        double x = 25.5;
        double y = 13;
        bool isInside = rect.IsInside(x, y);

        if (isInside)
        {
            Console.WriteLine($"点({x}, {y}) 在矩形内部。");
        }
        else
        {
            Console.WriteLine($"点({x}, {y}) 不在矩形内部。");
        }
    }
}