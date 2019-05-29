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
            Random random = new Random();
            // TEST
            BitArray64 bitArray64_1 = new BitArray64(1234);
            BitArray64 bitArray64_2 = new BitArray64(1234);


            Console.WriteLine("Before altering bits in second array");
            Console.WriteLine($"First array: {bitArray64_1}");
            Console.WriteLine($"First array number: {bitArray64_1.Number}");
            Console.WriteLine($"Second array: {bitArray64_2}");
            Console.WriteLine($"Second array number: {bitArray64_2.Number}");

            Console.WriteLine($"First Array is equal to Second Array: {bitArray64_1.Equals(bitArray64_2)}");
            Console.WriteLine($"First Array == Second Array: {bitArray64_1 == bitArray64_2}");
            Console.WriteLine($"First Array != Second Array: {bitArray64_1 != bitArray64_2}");

            Console.WriteLine("After altering bits in second array");
            for (int i = 0; i < bitArray64_2.Length; i+=random.Next(1, 6))
            {
                bitArray64_2[i] = 1;
            }

            Console.WriteLine($"First array: {bitArray64_1}");
            Console.WriteLine($"First array number: {bitArray64_1.Number}");
            Console.WriteLine($"Second array: {bitArray64_2}");
            Console.WriteLine($"Second array number: {bitArray64_2.Number}");
            Console.WriteLine($"First Array is equal to Second Array: {bitArray64_1.Equals(bitArray64_2)}");
            Console.WriteLine($"First Array == Second Array: {bitArray64_1 == bitArray64_2}");
            Console.WriteLine($"First Array != Second Array: {bitArray64_1 != bitArray64_2}");

            BitArray64 bitArray64_3 = new BitArray64(1234);
            bitArray64_3[4] = 1;


            Console.WriteLine("Values after changing a single bit!");
            Console.WriteLine($"First array: {bitArray64_1}");
            Console.WriteLine($"First array number: {bitArray64_1.Number}");
            Console.WriteLine($"Second array: {bitArray64_3}");
            Console.WriteLine($"Second array number: {bitArray64_3.Number}");
            Console.WriteLine($"First Array is equal to Third Array: {bitArray64_1.Equals(bitArray64_3)}");
            Console.WriteLine($"First Array == Third Array: {bitArray64_1 == bitArray64_3}");
            Console.WriteLine($"First Array != Third Array: {bitArray64_1 != bitArray64_3}");

            Console.ReadKey();
        }

            
    }
}
