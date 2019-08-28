using Parsely.Utility.Extensions;
using System;
using System.Numerics;
using Xunit;

namespace Parsely.UnitTests.Utility.UsingStringExtensions
{
    public class WhenValidatingToInteger
    {
        [Theory]
        [InlineData("0.00")]
        [InlineData("1.0")]
        [InlineData("1")]
        [InlineData("1.")]
        [InlineData("0")]
        [InlineData("-1")]
        [InlineData("-9999999999999999999999999")]
        [InlineData("9999999999999999999999999")]
        [InlineData("-9999999999999999999999999.9")]
        [InlineData("9999999999999999999999999.9")]
        [InlineData("-9999999999999999999999999.0")]
        [InlineData("9999999999999999999999999.0")]
        public void ShouldParseToInteger(string toCheck)
        {
            BigInteger integer = toCheck.ToInteger();

            Assert.Equal(BigInteger.Parse(toCheck), integer);
        }

        [Theory]
        [InlineData("1.1")]
        [InlineData("0.00000000000001")]
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
