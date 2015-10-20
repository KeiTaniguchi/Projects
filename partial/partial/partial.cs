using System;

namespace myapp
{
    public class myclass
    {
        public static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "taniguchi";
            p.age = 123;
            p.print();
            p.printAll();
            Console.ReadKey();
        }
    }

    public partial class Person
    {
        public string name;
        public void print()
        {
            Console.WriteLine("my name is" + name + ".");
        }
    }

    public partial class Person
    {
        public int age;
        public void printAll()
        {
            Console.WriteLine("my name is" + name + ". I'm" + age + "old.");
        }
    }
}


