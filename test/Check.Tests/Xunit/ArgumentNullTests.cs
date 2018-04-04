using CheckNET.Core.Extensions;
using CheckNET.Core.Interactives;
using Xunit;

namespace CheckNET.Tests.Xunit
{
    public class ArgumentNullTests
    {
        [Theory]
        [InlineData("Test")]
        [InlineData("T")]
        [InlineData("!")]
        [InlineData("1")]
        public void Can_CheckArgumentNull(string myString)
        {
            var argument = Check.Argument(myString.IsNotNull().And.IsNotEmpty());

            Assert.True(!string.IsNullOrEmpty(argument));
            Assert.True(argument == myString);
        }
    }
}
