using System;

// 1) 定义抽象类Animal
abstract class Animal
{
    // 属性
    public string Name { get; set; }

    // 构造方法
    public Animal(string name)
    {
        Name = name;
    }

    // 抽象方法
    public abstract void Enjoy();
}

// 2) 定义Cat类，继承自Animal
class Cat : Animal
{
    // 新属性
    public string EyesColor { get; set; }

    // 构造方法
    public Cat(string name, string eyesColor) : base(name)
    {
        EyesColor = eyesColor;
    }

    // 实现抽象方法
    public override void Enjoy()
    {
        Console.WriteLine($"{Name}正在用瞪大的{EyesColor}眼睛看着你，表示它很高兴！");
    }
}

// 3) 定义Dog类，继承自Animal
class Dog : Animal
{
    // 新属性
    public string FurColor { get; set; }

    // 构造方法
    public Dog(string name, string furColor) : base(name)
    {
        FurColor = furColor;
    }

    // 实现抽象方法
    public override void Enjoy()
    {
        Console.WriteLine($"{Name}正在摇着尾巴，以{FurColor}毛发闻起来很高兴！");
    }
}

// 4) 定义Lady类
class Lady
{
    // 属性
    public string Name { get; set; }
    public Animal Pet { get; set; }

    // 构造方法
    public Lady(string name, Animal pet)
    {
        Name = name;
        Pet = pet;
    }

    // 方法
    public void MyPetEnjoy()
    {
        Console.WriteLine($"{Name}的宠物{Pet.Name}正在享受快乐时光！");
        Pet.Enjoy();
    }
}

// 5) 测试类
class Program
{
    static void Main()
    {
        // 创建一只猫
        Cat cat = new Cat("小花", "蓝色");
        // 创建一个名为张女士的女士，养了这只猫
        Lady zhang = new Lady("张女士", cat);
        // 让这只猫笑一笑
        zhang.MyPetEnjoy();

        // 创建一只狗
        Dog dog = new Dog("小黑", "黑色");
        // 创建一个名为王女士的女士，养了这只狗
        Lady wang = new Lady("王女士", dog);
        // 让这只狗叫一叫
        wang.MyPetEnjoy();
    }
}
