using Parsely.UnitTests.Utilitiy.UsingTextUtility;
using Xunit;

namespace Parsely.UnitTests.Utility.UsingTextUtility
{
    public class WhenValidatingFloatAsInteger : TextUtilityTestBase
    {

        [Theory]
        [InlineData(1.0)]
        [InlineData(0.0)]
        [InlineData(-1.0)]
        public void ShouldValidateAsInteger(float toCheck)
        {
            Assert.True(Utility.IsInteger(toCheck));
        }

        [Theory]
        [InlineData(1.1)]
        [InlineData(0.9)]
        [InlineData(0.1)]
        [InlineData(-0.1)]
        [InlineData(-0.9)]
        public void ShouldNotValidateInteger(float toCheck)
        {
            Assert.False(Utility.IsInteger(toCheck));
        }
    }
}
