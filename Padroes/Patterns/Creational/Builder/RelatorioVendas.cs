using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.Builder
{
    public class RelatorioVendas : RelatorioBuilder
    {
        public RelatorioVendas()
        {
            Relatorio = new Relatorio();
        }

        public override void Cabecalho()
        {
            Relatorio.Cabecalho = "Relatório de vendas";
        }

        public override void Corpo()
        {
            Relatorio.Corpo = "Venda 1\nVenda 2\nVenda 3";
        }

        public override void Rodape()
        {
            Relatorio.Rodape = "----------------------";
        }
    }
}
