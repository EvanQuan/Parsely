using Parsely.Parsers.Interfaces;

namespace Parsely.Parsers.Implementations
{
    public class ParserFactory : IParserFactory
    {
        public static IParserFactory Instance { get; } = new ParserFactory();

        public IParser GetParser()
        {
            return Parser.Instance;
        }
    }
}
