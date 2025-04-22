using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class SymbolLogger:IMyLogger
    {

        public void printMessage(string txt)
        {

           
            Console.WriteLine("X" + "" + txt+" "+ "X");
        }
        public void printError(string txt)
        {
            Console.WriteLine(":)" + "" + txt+" "+":)");
        }
        public void printWarning(string txt)
        {
 
            Console.WriteLine("!" + "" + txt + " " + "!");
        }


    }
}
