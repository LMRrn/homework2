using System;
namespace hemowork02
{
    class Employee
    {
        public string name;
        public double salary;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Employee()
        {
            Console.WriteLine("请输入Name：");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("基本工资:");
            Salary = Convert.ToDouble(Console.ReadLine());
        }
        public void CalSalary()
        {
            Console.WriteLine("员工名字为{0}，基本工资为{1}。", Name, Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            a.CalSalary();
        }
    }
}