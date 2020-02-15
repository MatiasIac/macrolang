using System.Collections.Generic;

namespace macro.definition
{
    public class GrammarNode
    {
        public ExpressionBase Expression { get; set; }

        public List<GrammarNode> Children { get; set; }
    }
}