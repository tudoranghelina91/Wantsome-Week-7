using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQHOWTO
{
    class Program
    {
        static void Main(string[] args)
        {
            // linq cu FROM WHERE AND SELECT

            List<string> strings = new List<string>() { "Ionescu", "Magiun", "Faina", "Elon Musk", "Zdachi" };

            IEnumerable<string> stringsWithM = from s in strings
                                        where (s.Contains("m") || s.Contains("M"))
                                        select s;

            foreach (string s in stringsWithM)
                Console.WriteLine(s);

            var stringWithMWhere  = strings.Where(s => strings.)

            Console.ReadKey();
        }
    }
}
