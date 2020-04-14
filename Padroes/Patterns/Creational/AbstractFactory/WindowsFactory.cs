using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.AbstractFactory
{
    public class WindowsFactory : IGUIFactory
    {
        public IBotao CriarBotao()
        {
            return new BotaoWindows();
        }
    }
}
