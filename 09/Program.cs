using System;

// (1) 定义接口A
interface InterfaceA
{
    double Area();
}

// (2) 定义接口B
interface InterfaceB
{
    void SetColor(string color);
}

// (3) 定义接口C，继承了接口A和B
interface InterfaceC : InterfaceA, InterfaceB
{
    void Volume();
}

// (4) 定义圆柱体类Cylinder，实现接口C
class Cylinder : InterfaceC
{
    private double radius;
    private double height;
    private string color;

    public Cylinder(double radius, double height)
    {
        this.radius = radius;
        this.height = height;
    }

    public double Area()
    {
        return 2 * Math.PI * radius * (radius + height);
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public void Volume()
    {
        double volume = Math.PI * Math.Pow(radius, 2) * height;
        Console.WriteLine($"圆柱体的体积为：{volume}");
    }
}

// (5) 创建主类来测试类Cylinder
class Program
{
    static void Main()
    {
        Cylinder cylinder = new Cylinder(5.0, 10.0);
        cylinder.SetColor("红色");
        double area = cylinder.Area();

        Console.WriteLine($"圆柱体的表面积为：{area}");
        cylinder.Volume();
    }
}
