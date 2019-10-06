using Parsely.Utility.Extensions;
using System;
using System.Numerics;
using Xunit;

namespace Parsely.UnitTests.Utility.UsingStringExtensions
{
    public class WhenValidatingToInteger
    {
        [Theory]
        [InlineData("0.00", "0")]
        [InlineData("1.0", "1")]
        [InlineData("1", "1")]
        [InlineData("+1", "1")]
        [InlineData("0", "0")]
        [InlineData("-1", "-1")]
        [InlineData("-9999999999999999999999999", "-9999999999999999999999999")]
        [InlineData("9999999999999999999999999", "9999999999999999999999999")]
        [InlineData("-9999999999999999999999999.0", "-9999999999999999999999999")]
        [InlineData("9999999999999999999999999.0", "9999999999999999999999999")]
        [InlineData("00.00", "0")]
        [InlineData("01.0", "1")]
        [InlineData("01", "1")]
        [InlineData("+01", "1")]
        [InlineData("00", "0")]
        [InlineData("-01", "-1")]
        [InlineData("-09999999999999999999999999", "-9999999999999999999999999")]
        [InlineData("09999999999999999999999999", "9999999999999999999999999")]
        [InlineData("-09999999999999999999999999.0", "-9999999999999999999999999")]
        [InlineData("09999999999999999999999999.0", "9999999999999999999999999")]
        public void ShouldParseToInteger(String toCheck, String expected)
        {
            BigInteger integer = toCheck.ToInteger();

            Assert.Equal(BigInteger.Parse(expected), integer);
        }

        [Theory]
        [InlineData("1.1")]
        [InlineData("1.")]
        [InlineData("01.")]
        [InlineData(".0")]
        [InlineData("0.00000000000001")]
        [InlineData("-9999999999999999999999999.9")]
        [InlineData("9999999999999999999999999.9")]
        [InlineData("a")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("@")]
        public void ShouldThrowFormatException(string toCheck)
        {
            Assert.Throws<FormatException>(
                () =>
                {
                    toCheck.ToInteger();
                });
        }
    }
}
