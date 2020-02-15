using macro.codes;
using System;

namespace macro.exceptions
{
    public class LanguageException : Exception
    {
        public int CodeNumber { get; internal set; }

        public string ErrorMessage { get; set; }

        public LanguageException(ExceptionCodes code)
        {
            CodeNumber = (int)code;
            ErrorMessage = code.GetText();
        }
    }
}