using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> stringArr = new string[] { "32531235dssdg", "asedgseges532325", "afwawfwafwa", "325235dsafg", "213edfdsdvbsdbsdgbsdt4wwgfdsgds", "asdgvcdxbxfbdxf98b4ewt4398t" };
            IEnumerable<string> stringArrSorted = from anyString in stringArr
                                                  orderby anyString.Length descending
                                                  select anyString;

            Console.WriteLine("LONGEST STRING");
            Console.WriteLine(stringArrSorted.First());
            Console.ReadKey();
        }
    }
}
