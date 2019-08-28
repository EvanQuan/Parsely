using System;
using System.Numerics;

namespace Parsely.Utility.Extensions
{
    /// <summary>
    /// <see cref="string"/> extensions.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Check if this string is in the form of an integer, or a form that
        /// can be expressed as an integer.
        /// </summary>
        /// <param name="self"></param>
        /// <returns>true if in the form that can be expressed as an integer,
        /// else false</returns>
        public static bool IsInteger(this string self)
        {
            try
            {
                self.ToInteger();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Converts the <see cref="string"/> representation of a number to its
        /// <see cref="BigInteger"/> equivalent.
        /// </summary>
        /// <param name="self"></param>
        /// <exception cref="FormatException">If the string is not in the form
        /// of an integer</exception>
        /// <returns></returns>
        public static BigInteger ToInteger(this string self)
        {

            return BigInteger.Parse(self);
        }

        /// <summary>
        /// Check if a <see cref="string"/> can be parsed as an integer.
        /// </summary>
        /// <param name="toCheck">string to check</param>
        /// <param name="result">Parsed integer if successful, else 0
        /// <returns>true if the specified string can be parsed as an integer,
        /// else false</returns>
        public static bool TryParseAsInteger(this string self, out long integer)
        {
            integer = 0;
            return float.TryParse(self, out float result) ?
                long.TryParse(result.ToString(), out integer) : false;
        }
    }
}
