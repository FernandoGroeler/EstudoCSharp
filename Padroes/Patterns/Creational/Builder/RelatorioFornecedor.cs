using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.Builder
{
    public class RelatorioFornecedor : RelatorioBuilder
    {
        public RelatorioFornecedor()
        {
            Relatorio = new Relatorio();
        }

        public override void Cabecalho()
        {
            Relatorio.Cabecalho = "Relatório de fornecedor";
        }

        public override void Corpo()
        {
            Relatorio.Corpo = "Fornecedor 1\nFornecedor 2\nFornecedor 3";
        }

        public override void Rodape()
        {
            Relatorio.Rodape = "----------------------";
        }
    }
}
