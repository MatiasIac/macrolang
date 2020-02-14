using macro.command.lang_codes;
using macro.command.lang_exceptions;

namespace macro.command.extension
{
    internal static class Exceptions
    {
        private static void ThrowError(ExceptionCodes errorCode)
        {
            throw new LanguageException(errorCode);
        }

        public static void ThrowOnFalse(this bool b, ExceptionCodes errorCode)
        {
            if (!b) ThrowError(errorCode);
        }

        public static void ThrowOnTrue(this bool b, ExceptionCodes errorCode)
        {
            if (b) ThrowError(errorCode);
        }
    }
}