using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IODS.Handlers;

namespace ReadingANumber
{
    class Program
    {
        public static int ReadNumber(int start, int end)
        {
            int x = start;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());

                if (x < start)
                    throw new InvalidOperationException($"{x} does not meet the terms of equality! {x} is less than {start}");

                if (x > end)
                    throw new InvalidOperationException($"{x} does not meet the terms of equality! {x} is greater than {end}");
            }

            catch (FormatException)
            {
                throw;
            }

            catch (OverflowException)
            {
                throw;
            }

            return x;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (i > 0)
                    numbers[i] = ReadNumber(numbers[i - 1] + 1, 100);
                else
                    numbers[i] = ReadNumber(1, 100);
            }

            OutputHandling.PrintArray(numbers, numbers.Length, "Array contains: ");
            Console.ReadKey();
        }
    }
}
