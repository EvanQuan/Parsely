using Parsely.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Parsely.UnitTests.Utility.UsingStringExtensions
{
    public sealed class WhenRemovingDecimalPoints
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("0", "0")]
        [InlineData("00", "00")]
        [InlineData("10", "10")]
        [InlineData(".", "")]
        [InlineData(".0", "")]
        [InlineData("0.1", "0")]
        [InlineData("0.", "0")]
        [InlineData("0.0", "0")]
        [InlineData("00.0", "00")]
        [InlineData("10.0", "10")]
        [InlineData("0.00", "0")]
        [InlineData("0.01", "0")]
        [InlineData("0.10", "0")]
        [InlineData("10.00", "10")]
        [InlineData("10.01", "10")]
        [InlineData("10.10", "10")]
        [InlineData("01.00", "01")]
        [InlineData("01.01", "01")]
        [InlineData("01.10", "01")]
        [InlineData("99999999999999999999999999.10", "99999999999999999999999999")]
        [InlineData("-99999999999999999999999999.10", "-99999999999999999999999999")]
        public void ShouldRemoveCorrectly(String before, String expectedAfter)
        {
            String actualAfter = before.RemoveDecimalPoints();

            Assert.Equal(expectedAfter, actualAfter);
        }
    }
}
