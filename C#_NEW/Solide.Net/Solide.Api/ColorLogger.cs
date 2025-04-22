using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class ColorLogger : IMyLogger
    {
        public void printError(string txt)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("X" + "" + txt + " " + "X");
            Console.ResetColor();
        }

        public void printMessage(string txt)
        {
            Console.WriteLine(":)" + "" + txt + " " + ":)");
            Console.Beep();
        }

        public void printWarning(string txt)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!" + "" + txt + " " + "!");
            Console.ResetColor();
        }
    }
}
