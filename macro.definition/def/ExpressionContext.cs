using System.Collections.Generic;

namespace macro.definition
{
    public class ExpressionContext
    {
        public object Data { get; set; }

        public string ExpressionLine { get; internal set; }

        public int CurrentStep { get; internal set; }

        public List<string> ExpressionNames { get; internal set; }

        public List<ExpressionBase> ExpressionSteps { get; set; }

        public bool IsFaulty { get; set; }
        public string CurrentExpression { get; internal set; }

        public ExpressionContext(string expressionLine)
        {
            ExpressionLine = expressionLine;
        }

        public void MoveStep()
        {
            this.CurrentStep++;
        }
    }
}