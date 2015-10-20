using System;

namespace myapp
{
    class Program
    {
        public static void Main(string[] args)
        {
            EnchancedMyObject obj = new EnchancedMyObject();
            obj.name = "つやの";
            obj.age = 123;
            obj.mail = "syoda@tuyano.com";
            obj.printData();
            Console.ReadKey(); // キーを押すまで待つ
        }
    }

    class MyObject
    {
        public string name = "(noname)";
        public int age = 0;

        public virtual void printData()
        {
            Console.WriteLine("名前：{0}, 年齢：{1}歳", name, age);
        }
    }

    class EnchancedMyObject : MyObject
    {
        public string mail = "(no mail)";

        public override void printData()
        {
            Console.WriteLine("名前：{0}, 年齢：{1}歳, メール：{2}.", name, age, mail);
        }
    }
}

//{
//    public class Program
//    {
//        public static void Main(string[] args)
        
//        {
//            EnchancedMyObject obj = new EnchancedMyObject();
//            obj.name = "taniguchi";
//            obj.mail = "taniguchi@mail.com";
//            obj.printData();
//            Console.ReadKey();
//        }

//        class MyObject
//        {
//            public string name = "(noname)";
//            public virtual void printData()//virtual
//            {
//                Console.WriteLine("名前;{0}" , name);
//            }

//        }

//        class EnchancedMyObject : MyObject
//        {
//            public string mail = "(no mail)";
//            public override void printData()//override
//            {
//                Console.WriteLine("メール:{0} 名前:{1}", mail , name);
//            }
//        }

//    }
//}