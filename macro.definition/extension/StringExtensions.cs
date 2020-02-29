namespace macro.language.extension
{
    internal static class StringExtensions
    {
        public static int ToFinalQuote(this string s, int startIndex)
        {
            //TODO: throw error if startIndex is greater than s.length

            for (int i = startIndex; i < s.Length; i++)
            {
                if (i - 1 >= 0 && s[i] == '"' && s[i - 1] != '\\') return i;
            }

            return 0;
        }

        public static int GetIndexFor(this string s, int startIndex, char character)
        {
            for (int i = startIndex; i < s.Length; i++)
            {
                if (i - 1 >= 0 && s[i] == character) return i;
            }

            return 0;
        }
    }
}