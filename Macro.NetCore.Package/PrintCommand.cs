using macro.definition;
using macro.language.negotiators.NetCore;
using System;

namespace Macro.NetCore.Package
{
    [Command("print")]
    public class PrintCommand : ExpressionBase
    {
        public override void Interpret(ExpressionContext context)
        {
            throw new NotImplementedException();
        }
    }
}