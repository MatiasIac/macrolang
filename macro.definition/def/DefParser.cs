using macro.definition.negotiators;
using macro.extension;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using macro.exceptions;
using System;

namespace macro.definition
{
    public sealed class DefParser
    {
        private const string NEGOTIATOR_PATTERN = "(^> negotiator\t)(.*)";
        private const string NEGOTIATOR_COMMAND_TEXT = "> negotiator";
        private readonly NegotiatorBase _negotiator;

        public DefParser(NegotiatorBase negotiator)
        {
            _negotiator = negotiator;
        }

        public GrammarTree Parse()
        {
            var file = DefFile.GetDef();
            var lines = file
                .Substring(file.IndexOf("> lang") + 6)
                .Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var grammarTree = new GrammarTree
            {
                Nodes = new List<GrammarNode>()
            };

            foreach (var line in lines)
            {
                if (line.Trim().TrimStart().StartsWith("#")) continue;
                if (string.IsNullOrEmpty(line.Trim())) continue;
                if (line.Trim().StartsWith('>')) break;
                
                var splitedLine = line.Split('\t');
                var nodes = grammarTree.Nodes;

                CreateTree(nodes, splitedLine, 0);
            }

            return grammarTree;

            void CreateTree(List<GrammarNode> nodes, string[] splitedLine, int index)
            {
                var node = nodes.FirstOrDefault(n => n.Expression.Syntax == splitedLine[index].Trim());

                if (node == null)
                {
                    node = new GrammarNode
                    {
                        Children = new List<GrammarNode>(),
                        Expression = _negotiator.Intermediate(splitedLine[index].Trim())
                    };

                    nodes.Add(node);
                }

                if (splitedLine.Length > index + 1)
                {
                    CreateTree(node.Children, splitedLine, ++index);
                }
            }
        }

        public static string GetNegotiatorName()
        {
            var match = Regex
                .Match(DefFile.GetDef(),
                    NEGOTIATOR_PATTERN,
                    RegexOptions.Multiline);

            if (match.Success)
            {
                return match
                    .Groups
                    .Values
                    .FirstOrDefault(v => !v.Value.Contains(NEGOTIATOR_COMMAND_TEXT))
                    .Value
                    .Trim();
            }

            throw new LanguageException(codes.ExceptionCodes.NegotiatorNotPresent);
        }
    }
}