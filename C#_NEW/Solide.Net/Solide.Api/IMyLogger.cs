using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public interface IMyLogger
    {
        public void printMessage(string txt);
        public void printError(string txt);
        public void printWarning(string txt );

    }
}
