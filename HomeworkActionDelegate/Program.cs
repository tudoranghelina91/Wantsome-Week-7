using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkActionDelegate
{
    class Program
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            // EXAMPLE: ACTION DELEGATE
            Action<int> printActionDelegate = ConsolePrint;
            printActionDelegate(10);

            // EXAPLE: ANONYMOUS METHOD WITH ACTION DELEGATE
            Action<int> printActionDelegate2 = delegate (int i)
                                                {
                                                    Console.WriteLine(i);
                                                };

            printActionDelegate2(16);

            // EXAMPLE: LAMBDA EXPRESSON WITH ACTION DELEGATE
            Action<int> printActionDelegateLambda = i => Console.WriteLine(i);
            printActionDelegateLambda(111);
            Console.ReadKey();
        }
    }
}
