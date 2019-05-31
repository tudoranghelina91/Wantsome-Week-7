using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BitArr.Classes
{
    class BitArray64 : IEnumerable<int>
    {
        public ulong Number { get; private set; }
        private uint[] number = new uint[64];
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
                yield return (int)number[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Indexer

        public uint this[int index]
        {
            get
            {
                if (index >= 64 || index < 0)
                    throw new IndexOutOfRangeException("Only [0-63] are valid indexes");

                return number[index];
            }

            set
            {
                if (index >= 64)
                    throw new IndexOutOfRangeException("Only [0-63] are valid indexes");

                if (value > 1 || value < 0)
                    throw new InvalidOperationException("0 or 1 allowed only");

                number[index] = value;

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
            if (Number == (obj as BitArray64).Number && GetHashCode() == (obj as BitArray64).GetHashCode())
            {
                for (int i = 0; i < number.Length; i++)
                    if (this[i] != (obj as BitArray64)[i])
                        return false;

                return true;
            }

            return false;
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

        public override int GetHashCode()
        {
            int hash = 0;

            for (int i = 0; i < 64; i++)
            {
                hash += (int)((this[i]) * i);
            }

            return hash;
        }

        private void b2ToB10()
        {
            int i = number.Length - 1, px = 1;
            Number = 0;

            while (i >= 0)
            {
                Number = Number + number[i] * (ulong)px;
                px *= 2;
                i--;
            }
        }

        private void b10ToB2(ulong x, ref uint[] number)
        {
            for (int i = 0; i < number.Length; i++)
                number[i] = 0;

            while (x > 0)
            {
                this.number[k--] = (uint)(x % 2);
                x /= 2;
            }
        }
    }
}
