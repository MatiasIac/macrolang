using macro.command.extension;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace macro.command.def
{
    internal static class DefinitionReader
    {
        public static string Parse()
        {
            var definition = GetDef();

            return null;
        }

        private static string GetDef()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "macro.def");
            File.Exists(path).ThrowOnFalse(lang_codes.ExceptionCodes.FileNotFound);

            //TODO: Add better handling
            return File.ReadAllText(path);
        }
    }
}