using System;
using BitArr.Classes;


namespace BitArr
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64[] bitArray = Bit64ArrTest.BitArrays;

            Bit64ArrTest.Compare(bitArray[0], bitArray[1]);
            Bit64ArrTest.Compare(bitArray[0], bitArray[2]);
            Bit64ArrTest.SetRandomBits(ref bitArray[2]);
            Bit64ArrTest.Compare(bitArray[0], bitArray[2]);

            bitArray[3][12] = 1;
            Bit64ArrTest.Compare(bitArray[0], bitArray[3]);

            Console.WriteLine("Hashcodes of each number");
            foreach (BitArray64 arr in bitArray)
            {
                Console.WriteLine($"{arr.Number} - {arr} - {arr.GetHashCode()}");
            }

            Console.ReadKey();
        }

            
    }
}
