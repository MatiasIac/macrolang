using System;
using System.Collections.Generic;
using System.Text;

namespace macro.definition
{
    public class GrammarNode
    {
        public ExpressionBase Expression { get; set; }

        public IEnumerable<GrammarNode> Children { get; set; }
    }
}