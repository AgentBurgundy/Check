using CheckNET.Core.Extensions;
using CheckNET.Core.Interactives;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNET.Tests.NUnit
{
    [TestFixture]
    public class ArgumentNullTests
    {
        [Test]
        [TestCase("Test")]
        [TestCase("T")]
        [TestCase("!")]
        [TestCase("1")]
        public void Can_CheckArgumentNull(string myString)
        {
            var argument = Check.Argument(myString.IsNotNull().And.IsNotEmpty());

            Assert.That(!string.IsNullOrEmpty(argument));
            Assert.That(argument == myString);
        }
    }
}
