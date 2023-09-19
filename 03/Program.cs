
using System;

namespace hemowork03
{
    public class MyMath
    {
        public double jia(double x,double y)
        {
            return x+y;
        }
        public double jian(double x,double y)
        {
            return x-y;
        }
        public double cheng(double x,double y) { 
            return x*y;
        }
        public double chu(double x,double y)
        {
            if(y!=0)
            {
                return x/y;
            }
            return -1;
        }
    }
    class Program
    {
        static void Main()
        {
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            MyMath m = new MyMath();
            Console.WriteLine("加{0}，减{1}，乘{2}，除{3}。", m.jia(x,y), m.jian(x, y), m.cheng(x, y), m.chu(x, y));
        }
    }
}