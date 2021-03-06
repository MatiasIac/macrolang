﻿using macro.exceptions;
using macro.extension;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace macro.definition
{
    public sealed class DefFile
    {
        public static string GetDef()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "macro.def");
            File.Exists(path).ThrowOnFalse(codes.ExceptionCodes.FileNotFound);

            //TODO: Add better handling
            return File.ReadAllText(path);
        }
    }
}