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
            foreach (var line in definition)
            {
                var parsedLine = line.Split('\t');
            }

            return null;
        }

        private static IEnumerable<string> GetDef()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "macro.def");
            File.Exists(path).ThrowOnFalse(lang_codes.ExceptionCodes.FileNotFound);

            //TODO: Add better handling
            var defFile = File.ReadAllText(path);

            var defFileLines = defFile.Split('\n');
            var linesLength = defFileLines.Length;

            for (int i = 0; i < linesLength; i++)
            {
                yield return defFileLines[i];
            }
        }
    }
}