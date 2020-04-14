using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.AbstractFactory
{
    public class Aplicacao
    {
        public Aplicacao(IGUIFactory factory)
        {
            IBotao botao = factory.CriarBotao();
            botao.Pintar();
        }
    }
}
