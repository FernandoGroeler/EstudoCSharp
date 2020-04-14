using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Command
{
    public class ComandoFechar : IComando
    {
        public void Executar()
        {
            Console.WriteLine("Chamado comando fechar.");
        }
    }
}
