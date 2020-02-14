using macro.command.def;
using System;

namespace cli
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Parsing definition");
            
            DefinitionReader.Parse();


            Console.ReadLine();
        }
    }
}
