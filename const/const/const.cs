using System;

namespace myapp
{
    class Programa
    {
        public static void Main(String[] args)
        {
            Person p = new Person("taniguchi", 31);//コンストラクタをnewする。

            p.print();
            Console.ReadKey();
        }
    }
    public class Person
    {
        public string name;
        public int age;
        public Person(String name, int age)//newで初期化される変数
        {
            this.name = name;
            this.age = age;
        }

        public void print()
        {
            Console.WriteLine("my name is " + name + ".I'm" + age + "old.");
        }
    }
}





