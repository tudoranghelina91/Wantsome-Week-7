using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPredicateDelegate
{
    class Program
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
        static void Main(string[] args)
        {
            // EXAMPLE: PREDICATE DELEGATE
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!");
            Console.WriteLine(result);

            // EXAMPLE: PREDICATE DELEGATE WITH ANONYMOUS METHOD
            Predicate<string> isUpperAnon = delegate (string s)
                                            {
                                                return s.Equals(s.ToUpper());
                                            };

            bool resultanon = isUpperAnon("hello world!");
            Console.WriteLine(resultanon);

            // EXAMPLE PREDICATE DELEGATE WITH LAMBDA EXPRESSION
            Predicate<string> isUpperLambda = s => s.Equals(s.ToUpper());
            bool resultlambda = isUpperLambda("HELLO WORLD!");
            Console.WriteLine(resultlambda);
            Console.ReadKey();
        }
    }
}
