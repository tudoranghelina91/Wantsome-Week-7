using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFunc
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;
            int result = add(10, 10);
            Console.WriteLine(result);

            // FUNC WITH ANONYMOUS METHOD
            Func<int> getRandomNumber = delegate ()
                                        {
                                            Random rnd = new Random();
                                            return rnd.Next(1, 100);
                                        };

            // FUNC WITH LAMBDA EXPRESSION
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            // or

            Func<int, int, int> Sum2 = (x, y) => x + y;

            Console.WriteLine(Sum2(2, 7));

            Console.ReadKey();
        }
    }
}
