using Parsely.Utility.Extensions;
using Xunit;

namespace Parsely.UnitTests.Utility.UsingStringExtensions
{
    public class WhenValidatingIsInteger
    {
        [Theory]
        [InlineData("1")]
        [InlineData("0")]
        [InlineData("-1")]
        [InlineData("1.0")]
        [InlineData("0.0")]
        [InlineData("-1.0")]
        [InlineData("99999999999999999999999999999999999")]
        [InlineData("-99999999999999999999999999999999999")]
        [InlineData("99999999999999999999999999999999999.0")]
        [InlineData("-99999999999999999999999999999999999.0")]
        public void ShouldValidateAsInteger(string toCheck)
        {
            Assert.True(toCheck.IsInteger());
        }

        [Theory]
        [InlineData("1.1")]
        [InlineData("0.9")]
        [InlineData("0.1")]
        [InlineData("-0.1")]
        [InlineData("-0.9")]
        [InlineData("-99999999999999999999999999999.9")]
        [InlineData("99999999999999999999999999999.9")]
        public void ShouldNotValidateInteger(string toCheck)
        {
            Assert.False(toCheck.IsInteger());
        }
    }
}
