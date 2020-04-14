using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.Builder
{
    public class RelatorioCliente : RelatorioBuilder
    {
        public RelatorioCliente()
        {
            Relatorio = new Relatorio();
        }

        public override void Cabecalho()
        {
            Relatorio.Cabecalho = "Relatório de cliente";
        }

        public override void Corpo()
        {
            Relatorio.Corpo = "Cliente 1\nCliente 2\nCliente 3";
        }

        public override void Rodape()
        {
            Relatorio.Rodape = "----------------------";
        }
    }
}
