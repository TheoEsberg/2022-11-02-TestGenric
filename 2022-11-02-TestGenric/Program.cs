using System;

namespace _2022_11_02_TestGenric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool test1 = TestGeneric.Compare(1, 2);
            bool test2 = TestGeneric.Compare(2, 2);
            bool test3 = TestGeneric.Compare("hej", "hej");
            bool test4 = TestGeneric.Compare("Hej", "HEJ");

            Console.WriteLine("Första värdet är {0}", test1);
            Console.WriteLine("Andra värdet är {0}", test2);
            Console.WriteLine("Tredje värdet är {0}", test3);
            Console.WriteLine("Fjärde värdet är {0}", test4);

        }
    }
}
