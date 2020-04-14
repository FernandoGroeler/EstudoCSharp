using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Padroes.Patterns.Behavioral.Command.TestThread
{
    public static class TestCommandThread
    {
        public static void Testar()
        {
            Thread thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }

        private static void Run()
        {
            TestCommand.Testar();
        }
    }
}
