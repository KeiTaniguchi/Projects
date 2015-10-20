using System;

namespace myapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tax.tax = 5;
            Tax.calc(10000);
            Console.ReadKey();
        }
    }
    static class Tax
    {
        public static int tax;
        public static void calc(int price)
        {
            double price2 = price * (1.0 + (tax / 100.0));
            Console.WriteLine("金額：{0} 税込：{1}円", price, price2);
        }
    }
}