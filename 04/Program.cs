
using System;

namespace hemowork04
{
    public
    class Mymath
    {
        public double Pi = Math.PI;
        public void Perimeter(double r)//周长
        {
            Console.WriteLine(2 * r * Pi);
        }
        public void Area(double r)//面积
        {
            Console.WriteLine(r * r * Pi);
        }

    }
    class Program
    {
        static void Main()
        {
            Mymath circle1 = new Mymath(); //创建对象
            double r1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("圆的周长为：");
            circle1.Perimeter(r1);
            Console.Write("圆的面积为：");
            circle1.Area(r1);
        }
    }
}