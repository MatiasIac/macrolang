﻿namespace macro.definition
{
    public abstract class ExpressionBase
    {
        public string Syntax { get; set; }
        public bool IsTerminal { get; set; }

        public abstract void Interpret(ExpressionContext context);
    }
}