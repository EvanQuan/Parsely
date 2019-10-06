using System;
using System.Collections.Generic;
using System.Text;

namespace Parsely.Utility
{
    public static class RegularExpressions
    {
        public const String Start = @"^";
        public const String End = @"$";
        public const String Sign = @"[\+-]";
        public const String Digit = @"\d";
        public const String Decimal = @".";
        public const String ZeroOrMore = @"*";
        public const String OneOrMore = @"+";
        public const String ZeroOrOne = @"?";

        /// <summary>
        /// An integer or floating point number that represents an integer.
        /// </summary>
        public const String Integer =
            Start
            + (Sign + ZeroOrOne) // Optional sign
            + (Digit + ZeroOrMore) // Some number of digits
            + "("
                + Decimal
                + "0" // Zeros only allowed for decimals
                + OneOrMore
            + ")"
            + ZeroOrOne // Optional decimals
            + End;
    }
}
