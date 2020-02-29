using macro.definition.negotiators;
using macro.language.extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace macro.definition.language
{
    public sealed class LangParser
    {
        private readonly NegotiatorBase _negotiator;
        private readonly DefParser _defParser;

        public LangParser() : this(new NegotiatorService().GetDefault())
        {
        }

        public LangParser(NegotiatorBase negotiator)
        {
            _negotiator = negotiator;
            _defParser = new DefParser(_negotiator);
        }

        public void Execute(string lang)
        {
            var grammarTree = _defParser.Parse();

            foreach (var line in GetLines(lang))
            {
                Parse(line, grammarTree.Nodes, new ExpressionContext(line)
                {
                    CurrentStep = 0,
                    ExpressionSteps = new List<ExpressionBase>()
                });
            }

            static void Parse(string line, 
                List<GrammarNode> nodes,
                ExpressionContext context)
            {
                if (string.IsNullOrEmpty(line)) return;

                GrammarNode node = null;
                string currentExpression = string.Empty;
                
                if (line.StartsWith('\"'))
                {
                    //test for literal
                    node = nodes.FirstOrDefault(n => n.Expression.Syntax == "*");
                    currentExpression = line.Substring(0, line.ToFinalQuote(1) + 1);
                }
                else if (line.StartsWith('{'))
                {
                    //test for expression
                    node = nodes.FirstOrDefault(n => n.Expression.Syntax == "?");
                    currentExpression = line.Substring(0, line.GetIndexFor(1, '}') + 1);
                }
                else
                {
                    //any other defined syntax
                    node = nodes.FirstOrDefault(n => line.IndexOf(n.Expression.Syntax) >= 0);
                    currentExpression = node.Expression.Syntax;
                }
                
                if (node != null)
                {
                    context.ExpressionSteps.Add(node.Expression);
                    context.ExpressionLine = line;
                    context.CurrentExpression = currentExpression;
                    node.Expression.Interpret(context);

                    context.MoveStep();

                    var tailingLine = line.Substring(currentExpression.Length).TrimStart();
                    Parse(tailingLine, node.Children, context);
                }
            }
        }

        public static IEnumerable<string> GetLines(string lang)
        {
            var langLines = lang.Split('\n');
            var linesLength = langLines.Length;

            for (int i = 0; i < linesLength; i++)
            {
                yield return langLines[i];
            }
        }
    }
}