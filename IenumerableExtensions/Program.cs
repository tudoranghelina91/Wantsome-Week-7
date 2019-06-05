using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IenumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> @this)
        {
            dynamic sum = 0;
            foreach (var element in @this)
                sum += element;

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> @this)
        {
            dynamic product = 1;
            foreach (var element in @this)
                product *= element;

            return product;
        }

        public static T Min<T>(this IEnumerable<T> @this)
        {
            dynamic min = @this.First();
            foreach (var element in @this)
                if (element < min)
                    min = element;

            return min;
        }

        public static T Max<T>(this IEnumerable<T> @this)
        {
            dynamic max = @this.First();
            foreach (var element in @this)
                if (element > max)
                    max = element;

            return max;
        }

        public static double Average<T>(this IEnumerable<T> @this)
        {
            dynamic sum = 0;
            foreach (var element in @this)
                sum += element;

            return (double)sum / @this.Count();
        }

        public static void Print<T>(this IEnumerable<T> @this)
        {
            Console.Write("VALUES in Enumerable: ");
            foreach (var element in @this)
                Console.Write($"{element} ");

            Console.WriteLine();

            Console.WriteLine($"Sum: {@this.Sum()}");
            Console.WriteLine($"Product: {@this.Product()}");
            Console.WriteLine($"Min: {@this.Min()}");
            Console.WriteLine($"Max: {@this.Max()}");
            Console.WriteLine($"Average: {@this.Average()}");

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] intarr = new int[] { 12, 8, 9, 7, 1 };
            double[] doublearr = new double[] { 12.23124, 8.3122, 9.1221321, 7.122142 };
            float[] floatarr = new float[] { 12.2213f, 8.32124354f, 9.122343f, 7.1246f };
            intarr.Print();
            doublearr.Print();
            floatarr.Print();

            Console.ReadKey();
        }
    }
}
