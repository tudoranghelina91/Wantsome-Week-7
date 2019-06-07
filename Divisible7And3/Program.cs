using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> arrofInts = new int[] { 1, 49, 5, 3, 21, 7, 14, 50, 15, 45, 49 };

            IEnumerable<int> div7and3Ext = arrofInts.Where(x => (x % 7 == 0 && x % 3 == 0));

            IEnumerable<int> div7And3Linq = from integer in arrofInts
                                            where integer % 3 == 0 && integer % 7 == 0
                                            select integer;

            Console.WriteLine("EXTENSION: METHODS: ");
            foreach (int el in div7and3Ext)
                Console.Write(el);

            Console.WriteLine();

            Console.WriteLine("ELINQ: ");
            foreach (int el in div7And3Linq)
                Console.Write(el);

            Console.ReadKey();
            
        }
    }
}
