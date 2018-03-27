using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CheckNET.Core;
using CheckNET.Core.Extensions;
using CheckNET.Core.Interactives;

namespace CheckNET.Tests
{
    [TestFixture]
    public class StringTests
    {
        [Test]
        [TestCase("1")]
        [TestCase("Hello")]
        [TestCase("!Hello1")]
        [TestCase("!!$@#*U")]
        public void Check_IsNotNullOrEmpty(string testString)
        {
            Check.That(testString.IsNotNullOrEmpty());
        }

        [Test]
        [TestCase("1")]
        [TestCase("Hello")]
        [TestCase("!Hello1")]
        [TestCase("")]
        public void Check_IsNotNull(string testString)
        {
            Check.That(testString.IsNotNull());
        }

        [Test]
        [TestCase("Hello")]
        [TestCase("!Hello1")]
        [TestCase("!!$@#*U")]
        public void Check_IsNotEmpty(string testString)
        {
            Check.That(testString.IsNotEmpty());
        }

        [Test]
        [TestCase("Hello!")]
        [TestCase("!Hello1")]
        [TestCase("!!$H@#*U")]
        public void Check_Contains(string testString)
        {
            string[] commonStrings = new string[] { "!", "H" };

            Check.That(testString.ContainsThese(commonStrings));
        }

        [Test]
        [TestCase("Hello!")]
        [TestCase("!Hello1")]
        [TestCase("!!$H@#*U")]
        public void Check_MeetsCondition(string testString)
        {
            string[] commonStrings = new string[] { "!", "H" };

            foreach (var common in commonStrings)
            {
                Check.That(testString.MeetsCondition(s => s.Contains(common)));
            }
        }
    }
}
