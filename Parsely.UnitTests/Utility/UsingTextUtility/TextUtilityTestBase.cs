using Parsely.Utility;
using Parsely.Utility.Implementations;

namespace Parsely.UnitTests.Utilitiy.UsingTextUtility
{
    public abstract class TextUtilityTestBase
    {
        protected ITextUtility Utility;

        protected TextUtilityTestBase()
        {
            Utility = TextUtility.Instance;
        }

    }
}
