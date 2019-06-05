using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("awgsehgresdhre3543erfsdgsdgesr");
            Console.WriteLine(sb);
            Console.WriteLine(sb.Substring(3));
            Console.WriteLine(sb.Substring(6, 12));

            // EMPTY STRING BUILDER
            sb = new StringBuilder();
            Console.WriteLine(sb);
            Console.WriteLine(sb.Substring(3));
            Console.WriteLine(sb.Substring(3, 12));
            

            Console.ReadKey();
        }
    }
}
