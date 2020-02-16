using macro.definition.language;
using System;
using System.IO;

namespace cli
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("A macro script is required");
                return;
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine("Macro script not found");
                return;
            }

            var lang = File.ReadAllText(args[0]);

            new LangParser().Execute(lang);
        }
    }
}
