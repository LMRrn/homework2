using System;

// 定义动物类
class Animal
{
    public virtual void Voice()
    {
        Console.WriteLine("动物发出叫声");
    }
}

// 定义猫类，继承自动物类
class Cat : Animal
{
    public override void Voice()
    {
        Console.WriteLine("猫发出喵喵叫声");
    }
}

// 定义猪类，继承自动物类
class Pig : Animal
{
    public override void Voice()
    {
        Console.WriteLine("猪发出哼哼叫声");
    }
}

// 定义狗类，继承自动物类
class Dog : Animal
{
    public override void Voice()
    {
        Console.WriteLine("狗发出汪汪叫声");
    }
}

// 定义宠物店类
class Store
{
    // 创建单例实例
    private static Store instance = new Store();

    private Store() { }

    // getInstance方法根据传入的参数返回相应的动物对象
    public static Animal GetInstance(string animalType)
    {
        switch (animalType.ToLower())
        {
            case "dog":
                return new Dog();
            case "pig":
                return new Pig();
            default:
                return new Cat();
        }
    }
}

class Program
{
    static void Main()
    {
        // 测试代码
        Animal animal1 = Store.GetInstance("dog");
        animal1.Voice(); // 输出：狗发出汪汪叫声

        Animal animal2 = Store.GetInstance("pig");
        animal2.Voice(); // 输出：猪发出哼哼叫声

        Animal animal3 = Store.GetInstance("cat");
        animal3.Voice(); // 输出：猫发出喵喵叫声
    }
}
