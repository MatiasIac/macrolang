using macro.extension;
using macro.language.negotiators.NetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace macro.definition.negotiators
{
    public sealed class NetCore : NegotiatorBase
    {
        private const string NETCORE_ASSEMBLY = "Macro.NetCore.Package";

        private readonly Dictionary<string, Type> _availableTypes;

        public NetCore()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            //currentDomain.Load(NETCORE_ASSEMBLY);

            var types = Assembly.GetExecutingAssembly().GetTypes()
                //.Where(a => a.FullName.StartsWith("Macro.NetCore.Package"))
                //.SelectMany(a => a.GetTypes())
                .Where(t => 
                    t.GetCustomAttributes(typeof(CommandAttribute)).Count() > 0 &&
                    t.IsClass && t.IsSubclassOf(typeof(ExpressionBase)))
                .Select(t => new { key = t.GetCustomAttribute<CommandAttribute>().CommandName, value = t })
                .ToDictionary(k => k.key, v => v.value);
            
            _availableTypes = types;
        }

        public override ExpressionBase Intermediate(string keyword)
        {
            _availableTypes
                .ContainsKey(keyword)
                .ThrowOnFalse(codes.ExceptionCodes.NoExpressionFoundWithName);

            var expression = (ExpressionBase)Activator
                .CreateInstance(_availableTypes[keyword]);

            expression.Syntax = keyword;

            return expression;
        }
    }
}