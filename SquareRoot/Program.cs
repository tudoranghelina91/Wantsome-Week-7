using System;
using IODS.Handlers;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            InvalidOperationException invalidOperationException = new InvalidOperationException(message: "Invalid number");

            try
            {
                int x = Convert.ToInt32(Console.ReadLine());

                if (x < 0)
                    throw invalidOperationException;

                Console.WriteLine("{0:F3}", Math.Sqrt(x));
            }

            catch
            {
                OutputHandling.Error("Invalid number");
            }

            finally
            {
                OutputHandling.Message("Good bye!");
                Console.ReadKey();
            }

        }
    }
}
