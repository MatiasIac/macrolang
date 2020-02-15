using System;
using System.Collections.Generic;
using System.Text;

namespace macro.definition.negotiators
{
    public abstract class NegotiatorBase
    {
        public abstract ExpressionBase Intermediate(string keyword);
    }
}