using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMethodHOWTO
{
    class Program
    {
        public delegate void PrintDelegate(int x);
        public static void PrintEven(int x)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(x);
            Console.ResetColor();
        }

        public static void PrintOdd(int x)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(x);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            PrintDelegate print;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                    print = PrintEven;

                else
                    print = PrintOdd;

                print(i);
            }

            Console.ReadKey();
        }
    }
}
