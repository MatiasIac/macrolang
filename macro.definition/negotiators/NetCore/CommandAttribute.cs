using System;

namespace macro.language.negotiators.NetCore
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class CommandAttribute : Attribute
    {
        public string CommandName { get; set; }

        public CommandAttribute(string command)
        {
            CommandName = command;
        }
    }
}