using CheckNET.Core.Extensions;
using CheckNET.Core.Interactives;
using Xunit;

namespace CheckNET.Tests.Xunit
{
    public class IntTests
    {
        [Theory]
        [InlineData(10, 2)]
        [InlineData(20, 10)]
        [InlineData(100, 5)]
        public void Check_IsDivisibleBy(int value, int divisor)
        {
            Check.That(value.IsDivisbleBy(divisor));
        }

        [Theory]
        [InlineData(10, 2)]
        [InlineData(20, 10)]
        [InlineData(100, 5)]
        public void Check_NullableIsDivisibleBy(int? value, int? divisor)
        {
            Check.That(value.IsDivisbleBy(divisor));
        }

    }
}
