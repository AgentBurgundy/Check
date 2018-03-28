using CheckNET.Core.Interactives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNET.Core.Extensions
{
    public static class NullableIntExtensions
    {
        public static Check<int?> IsDivisbleBy(this int? val, int? divisor)
        {
            var checkedValue = val ?? throw new ArgumentNullException("Cannot evaluate IsDivisibleBy() with a null int value.-");
            var checkedDivisor = divisor ?? throw new ArgumentNullException("Cannot evaluate IsDivisibleBy() with a null divisor.");

            if (val % divisor > 0)
                throw new ArgumentException($"Value {val} is not divisible by {divisor}.");

            return new Check<int?>(val, true);
        }
    }
}
