using macro.definition;
using macro.language.negotiators.NetCore;
using System;

namespace Macro.NetCore.Package
{
    [Command("*")]
    public class LiteralCommand : ExpressionBase
    {
        public override void Interpret(ExpressionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
