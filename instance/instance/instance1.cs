using System;

namespace myapp
{
    public class insclass
    {
        public static void Main(string[] args)
        {
            Myins ins = new Myins();
            ins.name = "taniguchi";
            ins.age = 123;
            ins.printData();
            Console.ReadKey();
        }
    }
    
    public class Myins
    {
        public string name = "hogehoge";
        public int age;
        public void printData()
        {
            Console.WriteLine("名前:{0}, 年齢:{1}", name, age);
        }
    }
}