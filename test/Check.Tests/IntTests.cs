using CheckNET.Core.Extensions;
using CheckNET.Core.Interactives;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNET.Tests
{
    [TestFixture]
    public class IntTests
    {
        [Test]
        [TestCase(10, 2)]
        [TestCase(20, 10)]
        [TestCase(100, 5)]
        public void Check_IsDivisibleBy(int value, int divisor)
        {
            Check.That(value.IsDivisbleBy(divisor));
        }

        [Test]
        [TestCase(10, 2)]
        [TestCase(20, 10)]
        [TestCase(100, 5)]
        public void Check_NullableIsDivisibleBy(int? value, int? divisor)
        {
            Check.That(value.IsDivisbleBy(divisor));
        }

    }
}
