using System;
using Parsely.Utility.Extensions;
using Xunit;

namespace Parsely.UnitTests.Utility.UsingStringExtensions
{
    public class WhenValidatingIsInteger
    {
        /// <summary>
        /// Larger than <see cref="Double.MaxValue"/>
        /// </summary>
        private const String LargeInteger = "999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999";
        private const String ManyZeros = "000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";

        [Theory]
        [InlineData("1")]
        [InlineData("+1")]
        [InlineData("-1")]
        [InlineData("01")]
        [InlineData("+01")]
        [InlineData("-01")]
        [InlineData("0")]
        [InlineData("00")]
        [InlineData("+0")]
        [InlineData("+00")]
        [InlineData("-0")]
        [InlineData("-00")]
        [InlineData("1.0")]
        [InlineData("0.0")]
        [InlineData("-1.0")]
        [InlineData("01.0")]
        [InlineData("00.0")]
        [InlineData("-01.0")]
        [InlineData(LargeInteger)]
        [InlineData("-" + LargeInteger)]
        [InlineData(LargeInteger + ".0")]
        [InlineData(LargeInteger + "." + ManyZeros)]

        public void ShouldValidateAsInteger(string toCheck)
        {
            Assert.True(toCheck.IsInteger());
        }

        [Theory]
        [InlineData("1.1")]
        [InlineData("+1.1")]
        [InlineData("-1.1")]
        [InlineData("0.1")]
        [InlineData("0.2")]
        [InlineData("0.3")]
        [InlineData("0.4")]
        [InlineData("0.5")]
        [InlineData("0.6")]
        [InlineData("0.7")]
        [InlineData("0.8")]
        [InlineData("0.9")]
        [InlineData("0.01")]
        [InlineData("0.02")]
        [InlineData("0.03")]
        [InlineData("0.04")]
        [InlineData("0.05")]
        [InlineData("0.06")]
        [InlineData("0.07")]
        [InlineData("0.08")]
        [InlineData("0.09")]
        [InlineData("1." + ManyZeros + "1")]
        [InlineData("1." + ManyZeros + "2")]
        [InlineData("1." + ManyZeros + "3")]
        [InlineData("1." + ManyZeros + "4")]
        [InlineData("1." + ManyZeros + "5")]
        [InlineData("1." + ManyZeros + "6")]
        [InlineData("1." + ManyZeros + "7")]
        [InlineData("1." + ManyZeros + "8")]
        [InlineData("1." + ManyZeros + "9")]
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
