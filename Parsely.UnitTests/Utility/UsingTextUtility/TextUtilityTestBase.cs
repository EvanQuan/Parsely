using Parsely.Utility;
using Parsely.Utility.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

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
