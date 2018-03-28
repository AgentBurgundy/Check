using CheckNET.Core.Interactives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNET.Core.Extensions
{
    public static class IntExtensions
    {
        public static Check<int> IsDivisbleBy(this int val, int divisor)
        {
            if (val % divisor > 0)
                throw new ArgumentException($"Value {val} is not divisible by {divisor}.");

            return new Check<int>(val, true);
        }
    }
}
