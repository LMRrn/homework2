
using System;

namespace hemowork01
{
    public class rect
    {
        private double h, w;

        public rect(double h, double w)
        {
            this.h = h;
            this.w = w;
        }
        public double area()
        {
            return h * w;
        }
        public double cir()
        {
            return (h + w) * 2;
        }
    }
    class Program
    {
        static void Main()
        {
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            rect R = new rect(x, y);
            Console.WriteLine("矩形周长为{0}，矩形面积为{1}。", R.cir(), R.area());


        }
    }
}