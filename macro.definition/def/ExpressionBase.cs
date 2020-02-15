namespace macro.def
{
    internal abstract class ExpressionBase
    {
        public string Syntax { get; set; }
        public string Handler { get; set; }
        public bool IsTerminal { get; set; }

        public abstract void Interpret(ExpressionContext context);
    }
}