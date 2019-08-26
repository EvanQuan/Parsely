using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Parsely.UnitTests.Utilitiy.UsingTextUtility
{
    public class WhenParsingFloatToInteger : TextUtilityTestBase
    {
        [Theory]
        [InlineData(-1.0f, -1)]
        [InlineData(0.0f, 0)]
        [InlineData(1.0f, 1)]
        public void ShouldParseFloatToInteger(float toParse, int expectedResult)
        {
            Assert.Equal(
                expected: expectedResult,
                actual: Utility.ParseFloatToInteger(toParse));
        }

        [Theory]
        [InlineData(-1.1f, -2)]
        [InlineData(-0.9f, -1)]
        [InlineData(-0.1f, -1)]
        [InlineData(0.1f, 0)]
        [InlineData(0.9f, 0)]
        [InlineData(1.1f, 1)]
        public void ShouldNotParseFloatToInteger(float toParse, int expectedResult)
        {
            Assert.Equal(
                expected: expectedResult,
                actual: Utility.ParseFloatToInteger(toParse));
        }
    }
}
