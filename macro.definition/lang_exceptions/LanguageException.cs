﻿using macro.lang_codes;
using System;

namespace macro.lang_exceptions
{
    public class LanguageException : Exception
    {
        public int CodeNumber { get; internal set; }

        public string ErrorMessage { get; set; }

        public LanguageException(lang_codes.ExceptionCodes code)
        {
            CodeNumber = (int)code;
            ErrorMessage = code.GetText();
        }
    }
}