using Parsely.UnitTests.Utilitiy.UsingTextUtility;
using Xunit;

namespace Parsely.UnitTests.Utility.UsingTextUtility
{
    public class WhenValidatingStringAsInteger : TextUtilityTestBase
    {
        [Theory]
        [InlineData("1.0")]
        [InlineData("0.0")]
        [InlineData("-1.0")]
        public void ShouldValidateAsInteger(string toCheck)
        {
            Assert.True(Utility.IsInteger(toCheck));
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
            Assert.False(Utility.IsInteger(toCheck));
        }
    }
}
