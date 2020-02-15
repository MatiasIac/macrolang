using System.Collections.Generic;

namespace macro.definition
{
    public class ExpressionContext
    {
        public object Data { get; set; }

        public string ExpressionLine { get; internal set; }

        public IEnumerable<string> ExpressionSteps { get; internal set; }

        public bool IsFaulty { get; set; }

        public ExpressionContext(string expressionLine)
        {
            ExpressionLine = expressionLine;
        }
    }
}