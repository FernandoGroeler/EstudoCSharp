using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Command
{
    public class ComandoAbrir : IComando
    {
        public void Executar()
        {
            Console.WriteLine("Chamado comando abrir.");
        }
    }
}
