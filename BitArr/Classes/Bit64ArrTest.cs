using System;

namespace BitArr.Classes
{
    class Bit64ArrTest
    {
        private static BitArray64 bitArray64_1 = new BitArray64(1234);
        private static BitArray64 bitArray64_2 = new BitArray64(1234);
        private static BitArray64 bitArray64_3 = new BitArray64(1234);
        private static BitArray64 bitArray64_4 = new BitArray64(1234);

        public static BitArray64[] BitArrays = new BitArray64[] { bitArray64_1, bitArray64_2, bitArray64_3, bitArray64_4 };

        public static void Compare(BitArray64 arr1, BitArray64 arr2)
        {
            Console.WriteLine($"{arr1.Number} - {arr1}");
            Console.WriteLine($"{arr2.Number} - {arr2}");
            Console.WriteLine();
            Console.WriteLine($"{arr1.Number} equals to {arr2.Number}: {arr1.Equals(arr2)}");
            Console.WriteLine($"{arr1.Number} == {arr2.Number}: {arr1 == arr2}");
            Console.WriteLine($"{arr1.Number} != {arr2.Number}: {arr1 != arr2}");
            Console.WriteLine();
        }

        public static void SetRandomBits(ref BitArray64 arr)
        {
            Random randomPosition = new Random();
            Random randomValue = new Random();
            for (int i = 0; i < 64; i++)
            {
                arr[randomPosition.Next(0, 63)] = (uint)randomValue.Next(0, 1);
            }
        }
    }
}
