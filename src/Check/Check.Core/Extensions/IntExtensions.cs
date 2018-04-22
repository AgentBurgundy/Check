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

        public static Check<int> IsDivisbleBy(this int val, int? divisor)
        {
            if (divisor == null)
                throw new ArgumentNullException(nameof(divisor));

            if (val % divisor > 0)
                throw new ArgumentException($"Value {val} is not divisible by {divisor}.");

            return new Check<int>(val, true);
        }

        public static Check<int> StartsWith(this int val, int digit)
        {
            char[] digits = val.ToString().ToCharArray();

            if (!Int32.Parse(digits[0].ToString()).Equals(digit))
                throw new ArgumentException();

            return new Check<int>(val, true);
        }
    }
}
