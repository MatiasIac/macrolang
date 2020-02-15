using macro.extension;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace macro.definition
{
    public sealed class DefFile
    {
        private const string NEGOTIATOR_PATTERN = "(^> negotiator\t)(.*)";
        private const string NEGOTIATOR_COMMAND_TEXT = "> negotiator";

        public static string GetNegotiatorName()
        {
            var match = Regex
                .Match(GetDef(),
                    NEGOTIATOR_PATTERN,
                    RegexOptions.Multiline);

            if (match.Success)
            {
                return match
                    .Groups
                    .Values
                    .FirstOrDefault(v => !v.Value.Contains(NEGOTIATOR_COMMAND_TEXT))
                    .Value
                    .Trim();
            }

            return null;
        }

        public static IEnumerable<string> GetDefLines()
        {
            var defFile = GetDef();
            var defFileLines = defFile.Split('\n');
            var linesLength = defFileLines.Length;

            for (int i = 0; i < linesLength; i++)
            {
                yield return defFileLines[i];
            }
        }

        private static string GetDef()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "macro.def");
            File.Exists(path).ThrowOnFalse(codes.ExceptionCodes.FileNotFound);

            //TODO: Add better handling
            return File.ReadAllText(path);
        }
    }
}