using macro.definition.negotiators;
using macro.extension;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace macro.definition
{
    public sealed class DefParser
    {
        private readonly NegotiatorBase _negotiator;

        public DefParser(NegotiatorBase negotiator)
        {
            _negotiator = negotiator;
        }

        public GrammarTree Parse()
        {
            var definition = DefFile.GetDefLines();
            foreach (var line in definition)
            {
                if (line.TrimStart().StartsWith("#")) continue;

                var parsedLine = line.Split('\t');
            }

            return null;
        }

        
    }
}