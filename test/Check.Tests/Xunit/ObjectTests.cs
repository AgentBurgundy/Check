using CheckNET.Core.Extensions;
using CheckNET.Core.Interactives;
using Xunit;

namespace CheckNET.Tests.Xunit
{
    public class ObjectTests
    {
        [Theory]
        [InlineData("Hello", "Hello")]
        [InlineData(1, 1)]
        public void Check_EqualTo(object value1, object value2)
        {
            Check.That(value1.IsEqual(value2));
        }
    }
}
