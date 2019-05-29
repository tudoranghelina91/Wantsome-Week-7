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
            BitArray64 simpleArray = new BitArray64(123456);
            Console.WriteLine(simpleArray);
            Console.ReadKey();
        }
    }
}
