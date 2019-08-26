using Xunit;

namespace Parsely.UnitTests.Utilitiy.UsingTextUtility
{
    public class WhenUsingIsInteger
    {

        [Theory]
        [InlineData("0.00")]
        [InlineData("1.0")]
        [InlineData("1")]
        [InlineData("0")]
        [InlineData("-1")]
        public void ShouldParseAsInteger(string toCheck)
        {
            Assert.True(false);
        }

        [Theory]
        [InlineData("1.1")]
        [InlineData("0.00000000000001")]
        [InlineData("1.")]
        [InlineData("a")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("@")]
        public void ShouldNotParseAsInteger(string toCheck)
        {
            Assert.False(true);
        }
    }
}
