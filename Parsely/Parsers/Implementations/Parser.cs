using Parsely.Parsers.Interfaces;

namespace Parsely.Parsers.Implementations
{
    public class Parser : IParser
    {
        internal static IParser Instance { get; } = new Parser();

        private Parser()
        {

        }
    }
}
