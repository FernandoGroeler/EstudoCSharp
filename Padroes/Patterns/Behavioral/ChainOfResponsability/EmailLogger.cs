using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.ChainOfResponsability
{
    public class EmailLogger : Logger
    {
        public EmailLogger(int mask)
        {
            this.mask = mask;
        }

        protected static void WriteMessage(string msg)
        {
            Console.WriteLine($"Enviando e-mail: {msg}");
        }
    }
}
