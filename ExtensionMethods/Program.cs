using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = 12.912m;
            x.Add(14);
            x.Substract(2);
            x.Divide(3);
            x.Multiply(4);
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
