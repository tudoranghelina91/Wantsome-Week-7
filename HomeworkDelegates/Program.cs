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
            // EXAMPLE: C# DELEGATE

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

            // EXAMPLE: DELEGATE AS PARAMETER

            PrintHelper(PrintNumber, 100000);
            PrintHelper(PrintMoney, 100000);

            // EXAMPLE: MULTICAST DELEGATE

            printDelegate += PrintHexadecimal;
            printDelegate += PrintMoney;

            printDelegate(1000);

            printDelegate -= PrintHexadecimal;
            printDelegate(2000);

            Console.ReadKey();
        }

        // EXAMPLE: C# DELEGATE FUNCTIONS

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0, -12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        // EXAMPLE: DELEGATE AS PARAMETER FUNCTIONS

        public static void PrintHelper(Print delegateFunc, int numToPrint)
        {
            delegateFunc(numToPrint);
        }

        // EXAMPLE: MULTICAST DELEGATE FUNCTIONS
        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }


    }
}
