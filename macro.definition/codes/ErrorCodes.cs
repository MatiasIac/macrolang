using System.Collections.Generic;

namespace macro.codes
{
    public enum ExceptionCodes : int
    {
        ParsingError = 0x1,
        FileNotFound = 0x50,
        NegotiatorNotPresent = 0x80,
        NoDefaultNegotiatorFound = 0x81
    }

    public static class ErrorCodes
    {
        internal static Dictionary<ExceptionCodes, string> _errorCodeText = new Dictionary<ExceptionCodes, string>
        {
            { ExceptionCodes.FileNotFound, "File not found" },
            { ExceptionCodes.ParsingError, "Parsing error" },
            { ExceptionCodes.NegotiatorNotPresent, "Negotiator not found in definition file" },
            { ExceptionCodes.NoDefaultNegotiatorFound, "The selected negotiator is not a default one" }
        };

        public static string GetText(this ExceptionCodes code)
        {
            return _errorCodeText[code];
        }
    }
}