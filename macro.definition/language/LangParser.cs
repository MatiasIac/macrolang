using macro.definition.negotiators;
using System;
using System.Collections.Generic;
using System.Text;

namespace macro.definition.language
{
    public sealed class LangParser
    {
        private readonly NegotiatorBase _negotiator;

        public LangParser() : this(new NegotiatorService().GetDefault())
        {
        }

        public LangParser(NegotiatorBase negotiator)
        {
            _negotiator = negotiator;
        }

        public void Execute(string lang)
        {

        }

        public void Execute(StringBuilder lang)
        {

        }
    }
}