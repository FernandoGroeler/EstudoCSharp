using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.Singleton
{
    public static class TestSingleton
    {
        public static void Testar()
        {
            var singleton = MeuSingleton.GetInstance();
            Console.WriteLine(singleton.ToString());
        }
    }
}
