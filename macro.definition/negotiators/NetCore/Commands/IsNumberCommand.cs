using macro.definition;
using macro.language.negotiators.NetCore;
using System;
using System.Collections.Generic;

namespace Macro.NetCore.Package
{
    [Command("is_number")]
    public class IsNumberCommand : ExpressionBase
    {
        public override void Interpret(ExpressionContext context)
        {
            context.Data = new ExpressionIntermediator { HandleExpression = (s) =>
            {
                var exp = s.Split(',', StringSplitOptions.RemoveEmptyEntries);
                var type = "i";

                if (exp.Length == 2)
                {
                    type = exp[1];
                }

                switch (type)
                {
                    case "f":
                        Console.WriteLine(float.TryParse(exp[0], out _));
                        break;
                    case "d":
                        Console.WriteLine(double.TryParse(exp[0], out _));
                        break;
                    default:
                        Console.WriteLine(int.TryParse(exp[0], out _));
                        break;
                }
                
            }};
        }
    }
}