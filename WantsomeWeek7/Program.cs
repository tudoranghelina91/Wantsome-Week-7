using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WantsomeWeek7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = Console.ReadLine();
                var x = int.Parse(s);
                Console.WriteLine("Valid integer number {0}", x);

                if (x == 0)
                    throw new Exception("Number is 0");
            }

            catch (FormatException e)
            {
                Console.WriteLine("XXX - FORMAT EXCEPTION");
            }

            catch (OverflowException e)
            {
                Console.WriteLine("OVERFLOOOOOOOOOOOOOOOOOWWW!!!");
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            Console.ReadKey();
        }
    }
}
