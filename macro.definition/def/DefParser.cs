using macro.extension;
using System.Collections.Generic;
using System.IO;

namespace macro.def
{
    public static class DefParser
    {
        public static GrammarTree Parse()
        {
            var definition = GetDef();
            foreach (var line in definition)
            {
                if (line.TrimStart().StartsWith("#")) continue;

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