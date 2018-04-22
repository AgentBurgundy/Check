using CheckNET.Core.Extensions;
using CheckNET.Core.Interactives;
using NUnit.Framework;

namespace CheckNET.Tests.NUnit
{
    [TestFixture]
    public class FloatTests
    {
        [Test]
        [TestCase(10f, 2)]
        [TestCase(20f, 10)]
        [TestCase(100f, 5)]
        public void Check_IsDivisibleBy_Int(float value, int divisor)
        {
            Check.That(value.IsDivisibleBy(divisor));
        }

        [Test]
        [TestCase(10f, 2f)]
        [TestCase(20f, 10f)]
        [TestCase(100f, 5f)]
        public void Check_IsDivisibleBy_Float(float value, float divisor)
        {
            Check.That(value.IsDivisibleBy(divisor));
        }

        [Test]
        [TestCase(10f, 2)]
        [TestCase(20f, 10)]
        [TestCase(100f, 5)]
        public void Check_IsDivisibleBy_IntNullable(float value, int? divisor)
        {
            Check.That(value.IsDivisibleBy(divisor));
        }

        [Test]
        [TestCase(10f, 2f)]
        [TestCase(20f, 10f)]
        [TestCase(100f, 5f)]
        public void Check_IsDivisibleBy_FloatNullable(float value, float? divisor)
        {
            Check.That(value.IsDivisibleBy(divisor));
        }

        [Test]
        [TestCase(10f, 2)]
        [TestCase(20f, 10)]
        [TestCase(100f, 5)]
        public void Check_NullableIsDivisibleBy_IntNullable(float? value, int? divisor)
        {
            Check.That(value.IsDivisibleBy(divisor));
        }

        [Test]
        [TestCase(10f, 2f)]
        [TestCase(20f, 10f)]
        [TestCase(100f, 5f)]
        public void Check_NullableIsDivisibleBy_FloatNullable(float? value, float? divisor)
        {
            Check.That(value.IsDivisibleBy(divisor));
        }

        [Test]
        [TestCase(10f, 2)]
        [TestCase(20f, 10)]
        [TestCase(100f, 5)]
        public void Check_NullableIsDivisibleBy_Int(float? value, int divisor)
        {
            Check.That(value.IsDivisibleBy(divisor));
        }

        [Test]
        [TestCase(10f, 2f)]
        [TestCase(20f, 10f)]
        [TestCase(100f, 5f)]
        public void Check_NullableIsDivisibleBy_Float(float? value, float divisor)
        {
            Check.That(value.IsDivisibleBy(divisor));
        }

    }
}
