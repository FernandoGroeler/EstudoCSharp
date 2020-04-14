using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.ChainOfResponsability
{
    public class ConsoleLogger : Logger
    {
        public ConsoleLogger(int mask)
        {
            this.mask = mask;
        }

        protected static void WriteMessage(string msg)
        {
            Console.WriteLine($"Console.out: {msg}");
        }
    }
}
