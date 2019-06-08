using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTimer
{
    class Program
    {
        public static void MyMethod ()
        {
            Console.WriteLine("I have printed something, bby!");
        }

        static void Main(string[] args)
        {
            Timer myTimer = new Timer(1, MyMethod);
        }
    }
}
