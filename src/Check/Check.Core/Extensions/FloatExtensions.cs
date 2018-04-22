using CheckNET.Core.Interactives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNET.Core.Extensions
{
    public static class FloatExtensions
    {
        public static Check<float> IsDivisibleBy(this float value, float divisor)
        {
            if (value % divisor > 0)
                throw new ArgumentException($"Value {value} is not divisible by {divisor}.");

            return new Check<float>(value, true);
        }

        public static Check<float> IsDivisibleBy(this float value, int divisor)
        {
            if (value % divisor > 0)
                throw new ArgumentException($"Value {value} is not divisible by {divisor}.");

            return new Check<float>(value, true);
        }

        public static Check<float> IsDivisibleBy(this float value, float? divisor)
        {
            divisor = divisor ?? throw new ArgumentNullException(nameof(divisor));

            if (value % divisor > 0)
                throw new ArgumentException($"Value {value} is not divisible by {divisor}.");

            return new Check<float>(value, true);
        }

        public static Check<float> IsDivisibleBy(this float value, int? divisor)
        {
            divisor = divisor ?? throw new ArgumentNullException(nameof(divisor));

            if (value % divisor > 0)
                throw new ArgumentException($"Value {value} is not divisible by {divisor}.");

            return new Check<float>(value, true);
        }

        public static Check<float> StartsWith(this float val, int digit)
        {
            char[] digits = val.ToString().ToCharArray();

            if (!Int32.Parse(digits[0].ToString()).Equals(digit))
                throw new ArgumentException();

            return new Check<float>(val, true);
        }
    }
}
