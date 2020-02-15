using macro.extension;
using System;
using System.Collections.Generic;
using System.Text;

namespace macro.definition.negotiators
{
    public sealed class NegotiatorService
    {
        private Dictionary<string, NegotiatorBase> _defaultNegotiators = new Dictionary<string, NegotiatorBase>
        {
            { "NetCore", new NetCore() }
        };

        public NegotiatorBase GetDefault()
        {
            var negotiatorName = DefFile.GetNegotiatorName();
            
            _defaultNegotiators
                .ContainsKey(negotiatorName)
                .ThrowOnFalse(codes.ExceptionCodes.NoDefaultNegotiatorFound);
            
            return _defaultNegotiators[negotiatorName];
        }
    }
}