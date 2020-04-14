using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.Builder
{
    public static class TestBuilder
    {
        public static void Testar()
        {
            Diretor diretor = new Diretor
            {
                RelatorioBuilder = new RelatorioCliente()
            };

            diretor.Imprimir();

            Relatorio relatorio = diretor.Relatorio;

            Console.WriteLine(relatorio.ToString());
        }
    }
}
