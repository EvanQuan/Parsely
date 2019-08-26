using System;
using System.Collections.Generic;
using System.Text;

namespace Parsely.Utility
{
    /// <summary>
    /// Provides text utility functions
    /// </summary>
    public interface ITextUtility
    {
        /// <summary>
        /// Check if a <see cref="string"/> can be parsed as an integer.
        /// </summary>
        /// <param name="toCheck">string to check</param>
        /// <param name="result">Parsed integer if successful, else 0
        /// <returns>true if the specified string can be parsed as an integer,
        /// else false</returns>
        bool TryParseAsInteger(string toCheck, out int result);

        /// <summary>
        /// Check if a <see cref="float"/> can be parsed as an integer.
        /// </summary>
        /// <param name="toCheck">float to check</param>
        /// <param name="result">Parsed integer if successful, else 0
        /// <returns>true if the specified float can be parsed as an integer,
        /// else false</returns>
        bool TryParseAsInteger(float toCheck, out int result);

        /// <summary>
        /// Check if a float is an integer
        /// </summary>
        /// <param name="toCheck"><see cref="float"/> to check</param>
        /// <returns>true if toCheck is an integer, else false</returns>
        bool IsInteger(float toCheck);

        /// <summary>
        /// Check if a string is an integer
        /// </summary>
        /// <param name="toCheck"><see cref="string"/> to check</param>
        /// <returns>true if toCheck is an integer, else false</returns>
        bool IsInteger(string toCheck);

        /// <summary>
        /// Convert a float to an integer.
        /// </summary>
        /// <param name="toConvert"><see cref="float"/>to convert</param>
        /// <returns>The floor of the float</returns>
        int ParseFloatToInteger(float toConvert);
    }
}
