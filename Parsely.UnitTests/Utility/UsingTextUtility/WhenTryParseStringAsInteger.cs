using Parsely.Utility;
using Parsely.Utility.Implementations;
using System;
using Xunit;

namespace Parsely.UnitTests.Utilitiy.UsingTextUtility
{
    public class WhenTryParseStringAsInteger : TextUtilityTestBase
    {
        [Theory]
        [InlineData("0.00", 0)]
        [InlineData("1.0", 1)]
        [InlineData("1", 1)]
        [InlineData("1.", 1)]
        [InlineData("0", 0)]
        [InlineData("-1", -1)]
        public void ShouldTryParseStringAsInteger(string toCheck, int expectedResult)
        {
            bool isInteger = Utility.TryParseAsInteger(toCheck, out int actualResult);

            Assert.True(isInteger);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(-1.0f, -1)]
        [InlineData(0.0f, 0)]
        [InlineData(1.0f, 1)]
        [InlineData((float)int.MaxValue, int.MaxValue)]
        [InlineData((float)int.MinValue, int.MinValue)]
        public void ShouldTryParseFloatAsInteger(float toCheck, int expectedResult)
        {
            bool isInteger = Utility.TryParseAsInteger(toCheck, out int actualResult);

            Assert.True(isInteger, $"Expected {toCheck} to be an integer.");
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("1.1")]
        [InlineData("0.00000000000001")]
        [InlineData("a")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("@")]
        public void ShouldNotTryParseAsInteger(string toCheck)
        {
            bool isInteger = Utility.TryParseAsInteger(toCheck, out int actualResult);

            Assert.False(isInteger, $"Expected {toCheck} to not be an integer.");
            Assert.Equal(expected: 0, actualResult);
        }
    }
}
