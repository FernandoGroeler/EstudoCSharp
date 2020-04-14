using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.Builder
{
    public class Diretor
    {
        public Diretor()
        {
        }

        public void Imprimir()
        {
            RelatorioBuilder.Cabecalho();
            RelatorioBuilder.Corpo();
            RelatorioBuilder.Rodape();
        }

        public Relatorio Relatorio { get => RelatorioBuilder.Relatorio; }

        public RelatorioBuilder RelatorioBuilder { get; set; }
    }
}
