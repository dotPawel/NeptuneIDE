using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptuneIDE
{
    internal class CLI
    {
        public static void MainCLI()
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("NeptuneIDE CLI (aka debug console)");
            Console.WriteLine(@"youre on your own now ¯\_(ツ)_/¯");
            Console.WriteLine("------------------------------------------\n");
        }
        public static void CMD()
        {
            Console.Write(" CLI > ");
            string command = Console.ReadLine();
            Console.WriteLine();

            // commands here

            CMD();
        }
    }
}
