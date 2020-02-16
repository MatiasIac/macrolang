using macro.definition;
using macro.language.negotiators.NetCore;

namespace Macro.NetCore.Package
{
    [Command("*")]
    public class LiteralCommand : ExpressionBase
    {

        public override void Interpret(ExpressionContext context)
        {
            var expression = context
                .CurrentExpression
                .Substring(1, context.CurrentExpression.Length - 2);

            (context.Data as ExpressionIntermediator).HandleExpression(expression);
        }
    }
}