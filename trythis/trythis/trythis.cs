using System;

namespace myapp
{
    class Program
    {
        public static void Main(string[] args)
        {
            ExpectMyObject obj = new ExpectMyObject();
            obj.name = "谷口";
            obj.age = 30;
            obj.mail = "taniguchi@home.ne.jp";
            //obj.printData();
            obj.printDataExpected();

            MyObject baseObj = new MyObject();
            baseObj.name = "江頭";
            baseObj.age = 42;
            //baseObj.mail = "egasira@2hour.50min";//継承していないので、mailという変数はないことになる。
            //obj.printData();
            baseObj.printDataExpected();

            Console.ReadKey();
        }
    }

    //MyObjectインスタンスを作成
    class MyObject
    {
        public string name = "(noname)";
        public int age = 0;

        public void printDataExpected()
        {
            Console.WriteLine("名前:{0},年齢:{1}歳", name, age);
        }
    }

    //MyObjectを継承したExpectMyObjectを作成
    class ExpectMyObject : MyObject
    {
        public string mail = "(no mail)";
        public void printDataExpected()
        {
            Console.WriteLine("\t名前:{0}\n\t年齢:{1}歳\n\tメール{2}.", name, age, mail);
        }
    }
}
