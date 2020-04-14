using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.ChainOfResponsability
{
    public abstract class Logger
    {
        public static int ERRO = 3;
        public static int INFO = 5;
        public static int DEBUG = 7;

        protected int mask;

        protected Logger next;

        public Logger SetNext(Logger log)
        {
            next = log;
            return log;
        }

        public void Message(string msg, int priority)
        {
            if (priority == mask)
            {
                Console.WriteLine(msg);
                return;
            }

            if (next != null)
            {
                next.Message(msg, priority);
            }
        }
    }
}
