using System;

namespace myapp
{
    class program
    {
        public static void Main(string[]args)
        {
            Student p = new Student();
            p.name = "taniguchi";
            p.grade = 2;
            p.printData();
            Employee e = new Employee();
            e.name = "kei";
            e.position = "president";
            e.printData();
            Console.ReadKey();
        }
    }
    abstract class Person
    {
        public abstract void printData();
    }

    class Student : Person
    {
        public String name;
        public int grade;
        public override void printData()
        {
            Console.WriteLine("name:" + name + ", grade:" + grade + ".");
        }
    }

    class Employee : Person
    {
        public String name;
        public String position;
        public override void printData()
        {
            Console.WriteLine("Hi, my name is " + name + ". my position is" + position + ".");
        }
    }

}