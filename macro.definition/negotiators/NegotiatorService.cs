using macro.extension;
using System.Collections.Generic;

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
            var negotiatorName = DefParser.GetNegotiatorName();
            
            _defaultNegotiators
                .ContainsKey(negotiatorName)
                .ThrowOnFalse(codes.ExceptionCodes.NoDefaultNegotiatorFound);
            
            return _defaultNegotiators[negotiatorName];
        }
    }
}