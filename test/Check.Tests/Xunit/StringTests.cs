using CheckNET.Core.Extensions;
using CheckNET.Core.Interactives;
using Xunit;

namespace CheckNET.Tests.Xunit
{
    public class StringTests
    {
        [Theory]
        [InlineData("1")]
        [InlineData("Hello")]
        [InlineData("!Hello1")]
        [InlineData("!!$@#*U")]
        public void Check_IsNotNullOrEmpty(string testString)
        {
            Check.That(testString.IsNotNullOrEmpty());
        }

        [Theory]
        [InlineData("1")]
        [InlineData("Hello")]
        [InlineData("!Hello1")]
        [InlineData("")]
        public void Check_IsNotNull(string testString)
        {
            Check.That(testString.IsNotNull());
        }

        [Theory]
        [InlineData("Hello")]
        [InlineData("!Hello1")]
        [InlineData("!!$@#*U")]
        public void Check_IsNotEmpty(string testString)
        {
            Check.That(testString.IsNotEmpty());
        }

        [Theory]
        [InlineData("Hello!")]
        [InlineData("!Hello1")]
        [InlineData("!!$H@#*U")]
        public void Check_Contains(string testString)
        {
            string[] commonStrings = new string[] { "!", "H" };

            Check.That(testString.ContainsThese(commonStrings));
        }

        [Theory]
        [InlineData("Hello!")]
        [InlineData("!Hello1")]
        [InlineData("!!$H@#*U")]
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
