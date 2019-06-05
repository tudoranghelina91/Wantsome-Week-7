using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDelegates
{
    class Program
    {
        // declare delegate
        public delegate void Print(int value);

        static void Main(string[] args)
        {
            // Print delegate points to PrintNumber
            Print printDelegate = PrintNumber;

            // or
            // Print printDel = new Print(PrintNumber);

            printDelegate(100000);
            printDelegate(200);

            // Print delegate points to PrintMoney
            printDelegate = PrintMoney;

            printDelegate(10000);
            printDelegate(200);

            Console.ReadKey();
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0, -12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
    }
}
