using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Command
{
    public static class TestCommand
    {
        private static List<IComando> GetComandos()
        {
            List<IComando> lista = new List<IComando>
            {
                new ComandoAbrir(),
                new ComandoImprimir(),
                new ComandoFechar()
            };

            return lista;
        }

        public static void Testar()
        {
            foreach (var item in GetComandos())
                item.Executar();
        }
    }
}
