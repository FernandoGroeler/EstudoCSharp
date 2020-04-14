using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.ChainOfResponsability
{
    public class ErrorLogger : Logger
    {
        public ErrorLogger(int mask)
        {
            this.mask = mask;
        }

        protected static void WriteMessage(string msg)
        {
            Console.WriteLine($"ERROR: {msg}");
        }
    }
}
