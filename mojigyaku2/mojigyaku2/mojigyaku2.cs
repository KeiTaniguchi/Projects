using System;

namespace mojigyaku
{
    public class Mojigyaku
    {
        public static void Main(string[] args)
        {
            string mojiretsu = "stressed";
            char[] inputchar = mojiretsu.ToCharArray();
            Array.Reverse(inputchar);
            Console.WriteLine(new string(inputchar));

            Console.ReadKey();
        }
    }
}
