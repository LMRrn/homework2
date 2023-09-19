using System;

// (1) 定义接口 InterfaceA
interface InterfaceA
{
    void PrintCapitalLetter();
}

// (2) 定义接口 InterfaceB
interface InterfaceB
{
    void PrintLowercaseLetter();
}

// (3) 定义非抽象类 Print，实现接口 InterfaceA 和 InterfaceB
class Print : InterfaceA, InterfaceB
{
    public void PrintCapitalLetter()
    {
        for (char c = 'A'; c <= 'Z'; c++)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }

    public void PrintLowercaseLetter()
    {
        for (char c = 'a'; c <= 'z'; c++)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}

// (4) 编写测试程序
class Program
{
    static void Main()
    {
        // 创建 Print 的对象并赋值给 InterfaceA 的变量 a
        InterfaceA a = new Print();
        a.PrintCapitalLetter();

        // 创建 Print 的对象并将该对象赋值给 InterfaceB 的变量 b
        InterfaceB b = new Print();
        b.PrintLowercaseLetter();
    }
}
