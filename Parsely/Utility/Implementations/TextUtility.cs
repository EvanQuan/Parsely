using System;
using System.Collections.Generic;
using System.Text;

namespace Parsely.Utility.Implementations
{
    public class TextUtility : ITextUtility
    {
        public static ITextUtility Instance { get; } = new TextUtility();

        public bool IsInteger(float toCheck)
        {
            return Math.Floor(toCheck) == toCheck;
        }

        public bool IsInteger(string toCheck)
        {
            return TryParseAsInteger(toCheck, out _);
        }

        public int ParseFloatToInteger(float toConvert)
        {
            return (int)Math.Floor(toConvert);
        }

        public bool TryParseAsInteger(string toCheck, out int integer)
        {
            integer = 0;
            return float.TryParse(toCheck, out float result) ?
                int.TryParse(result.ToString(), out integer) : false;
        }

        public bool TryParseAsInteger(float toCheck, out int result)
        {
            float floor = (float)Math.Floor(toCheck);
            bool isInteger = floor == toCheck;

            if (isInteger)
            {
                result = (int)floor;
                return true;
            }

            result = 0;
            return false;
        }
    }
}
