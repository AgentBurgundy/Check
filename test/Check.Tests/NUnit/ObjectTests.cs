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
    public class ObjectTests
    {
        [Test]
        [TestCase("Hello", "Hello")]
        [TestCase(1, 1)]
        public void Check_EqualTo(object value1, object value2)
        {
            Check.That(value1.IsEqual(value2));
        }
    }
}
