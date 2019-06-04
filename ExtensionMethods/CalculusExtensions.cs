using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class CalculusExtensions
    {
        public static void Add(ref this decimal @this, decimal number)
        {
            @this += number;
        }

        public static void Substract(ref this decimal @this, decimal number)
        {
            @this -= number;
        }

        public static void Multiply(ref this decimal @this, decimal number)
        {
            @this *= number;
        }

        public static void Divide(ref this decimal @this, decimal number)
        {
            @this /= number;
        }
    }
}
