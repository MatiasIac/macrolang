namespace macro.language.extension
{
    internal static class StringExtensions
    {
        public static int ToFinalQuote(this string s, int startIndex)
        {
            //throw error if startIndex is greater than s.length

            for (int i = startIndex; i < s.Length; i++)
            {
                if (i - 1 >= 0 && s[i] == '"' && s[i - 1] != '\\') return i;
            }

            return 0;
        }
    }
}