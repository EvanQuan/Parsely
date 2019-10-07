using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Parsely.Utility.Extensions
{
    /// <summary>
    /// <see cref="String"/> extensions.
    /// </summary>
    public static class StringExtensions
    {
        public static String RemoveDecimalPoints(this String self)
        {
            Int32 decimalIndex = self.IndexOf('.');
            return decimalIndex == -1 ? self : self.Remove(decimalIndex);
        }

        public static Boolean IsMatch(this String self, in String pattern)
            => Regex.IsMatch(self, pattern);

        /// <summary>
        /// Check if this string is in the form of an integer, or a form that
        /// can be expressed as an integer.
        /// </summary>
        /// <param name="self"></param>
        /// <returns>true if in the form that can be expressed as an integer,
        /// else false</returns>
        public static Boolean IsInteger(this String self)
            => self.IsMatch(RegularExpressions.Integer);

        /// <summary>
        /// Converts the <see cref="String"/> representation of a number to its
        /// <see cref="BigInteger"/> equivalent.
        /// </summary>
        /// <param name="self"></param>
        /// <exception cref="FormatException">If the string is not in the form
        /// of an integer</exception>
        /// <returns></returns>
        public static BigInteger ToInteger(this String self)
        {
            if (self.IsInteger())
            {
                return BigInteger.Parse(self.RemoveDecimalPoints());
            }
            throw new FormatException($"{self} is not an integer.");
        }

        /// <summary>
        /// Check if a <see cref="String"/> can be parsed as an integer.
        /// </summary>
        /// <param name="self">string to check</param>
        /// <param name="integer">Parsed integer if successful, else 0
        /// <returns>true if the specified string can be parsed as an integer,
        /// else false</returns>
        public static Boolean TryParseAsInteger(this String self, out Int64 integer)
        {
            integer = 0;
            return Single.TryParse(self, out Single result) ?
                Int64.TryParse(result.ToString(), out integer) : false;
        }
    }
}
