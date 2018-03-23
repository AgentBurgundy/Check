using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CheckNET.Core;

namespace CheckNET.Tests
{
    [TestFixture]
    public class CheckTests
    {
        [Test]
        public void CheckIsNull()
        {
            string nullstring = null;

            Assert.That(Check.IsNull(nullstring));
        }

        [Test]
        public void CheckIsNotNull()
        {
            string emptystring = "";

            Assert.That(Check.IsNotNull(emptystring));
        }

        [Test]
        public void CheckIsEqual()
        {
            int? value = 100;
            int? expectedValue = 100;

            Assert.That(Check.IsEqual(value, expectedValue));
        }

        [Test]
        public void CheckIsNotEqual()
        {
            int? value = 100;
            int? expectedValue = 98;

            Assert.That(Check.IsNotEqual(value, expectedValue));
        }

        [Test]
        public void CheckMeetsCondition()
        {
            float? value = 100;
            float expectedValue = 50;
            float divisor = 2;

            Assert.That(Check.MeetsCondition(value, startingValue => startingValue / divisor == expectedValue));
        }
    }
}
