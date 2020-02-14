using System.Collections.Generic;

namespace macro.command.lang_codes
{

    public static class ErrorCodes
    {
        internal static Dictionary<ExceptionCodes, string> _errorCodeText = new Dictionary<ExceptionCodes, string>
        {
            { ExceptionCodes.FileNotFound, "File not found" },
            { ExceptionCodes.ParsingError, "Parsing error" }
        };

        public static string GetText(this ExceptionCodes code)
        {
            return _errorCodeText[code];
        }
    }
}