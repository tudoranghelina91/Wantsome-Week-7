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
        private ulong numberCpy;
        private ulong number;
        public int Length { get; set; } = 0;
        public ulong Number
        {
            get
            {
                return number;
            }

            set
            {
                int x = (int)value;
                while (x > 0)
                {
                    number = number * 10 + (ulong)(x % 2);


                    Length++;
                    x /= 2;
                }

            }
        }

        public BitArray64(ulong number)
        {
            Number = number;
            numberCpy = this.number;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
                yield return this[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int this[int index]
        {
            get
            {
                int x = (int)(numberCpy % 10);
                numberCpy /= 10;
                return x;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < Length; i++)
                output.Append(this[i]);

            return output.ToString();
        }
    }
}
