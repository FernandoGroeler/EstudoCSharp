using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.AbstractFactory
{
    public class BotaoWindows : IBotao
    {
        public void Pintar()
        {
            Console.WriteLine("Pintando botão Windows");
        }
    }
}
