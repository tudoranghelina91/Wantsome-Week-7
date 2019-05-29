using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitArr.Classes;

namespace BitArr
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 simpleArr = new BitArray64(999999999999);
            Console.WriteLine(simpleArr);
            Console.WriteLine(simpleArr.Number);
            for (int i = 3; i < 43; i+=2)
            {
                simpleArr[i] = 1;
            }
            Console.WriteLine(simpleArr);
            Console.WriteLine(simpleArr.Number);
            Console.ReadKey();
        }

            
    }
}
