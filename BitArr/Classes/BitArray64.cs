using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArr.Classes
{
    class BitArray64 : IEnumerable<int>
    {
        public ulong Number { get; private set; }
        private int[] number = new int[64];
        private int k = 63;
        public int Length { get; } = 64;

        // Constructor

        public BitArray64(ulong number)
        {
            Number = number;

            // transformam din baza 10 in baza 2;
            b10ToB2(number, ref this.number);
        }

        // Ienumerator and Ienumerable

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < number.Length; i++)
                yield return number[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Indexer

        public int this[int index]
        {
            get
            {
                if (index >= 64)
                    throw new IndexOutOfRangeException("Only [0-63] are valid indexes");

                return number[index];
            }

            set
            {
                if (index >= 64)
                    throw new IndexOutOfRangeException("Only [0-63] are valid indexes");

                else if (value > 1 || value < 0)
                    throw new InvalidOperationException("0 or 1 allowed only");

                else
                {
                    number[index] = value;
                }

                // transforma numarul nou in baza 10
                b2ToB10();
            }
        }

        // ToString

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < number.Length; i++)
                output.Append(number[i]);

            return output.ToString();
        }

        // Equals
        public override bool Equals(object obj)
        {
            foreach (int digit1 in this)
                foreach (int digit2 in obj as BitArray64)
                    if (digit1 != digit2)
                        return false;

            return true;
        }

        // == AND !=

        public static bool operator == (BitArray64 a, BitArray64 b)
        {
            return a.Equals(b);
        }

        public static bool operator != (BitArray64 a, BitArray64 b)
        {
            return !a.Equals(b);
        }

        private void b2ToB10()
        {
            int i = number.Length - 1, px = 1;
            Number = 0;

            while (i >= 0)
            {
                Number = Number + (ulong)number[i] * (ulong)px;
                px *= 2;
                i--;
            }
        }

        private void b10ToB2(ulong x, ref int[] number)
        {
            for (int i = 0; i < number.Length; i++)
                number[i] = 0;

            while (x > 0)
            {
                this.number[k--] = (int)(x % 2);
                x /= 2;
            }
        }
    }
}
