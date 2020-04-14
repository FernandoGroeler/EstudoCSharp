using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.TemplateMethod
{
    public class RelatorioVendas : BaseReport
    {
        public override string GetCabecalho()
        {
            return "Relatório de vendas";
        }

        public override string GetCorpo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(String.Format("%-10s\t%-40s%20s\n", "01/01/2012", "Banana", "R$ 10,00"));
            sb.Append(String.Format("%-10s\t%-40s%20s\n", "01/01/2012", "Abacate", "R$ 10,00"));
            sb.Append(String.Format("%-10s\t%-40s%20s\n", "01/01/2012", "Beterraba", "R$ 10,00"));
            sb.Append(String.Format("%-10s\t%-40s%20s\n", "01/01/2012", "Cenoura", "R$ 10,00"));
            sb.Append(String.Format("%-10s\t%-40s%20s\n", "01/01/2012", "Arroz", "R$ 10,00"));

            return sb.ToString();
        }

        public override string GetRodape()
        {
            return "Total R$ 50,00";
        }
    }
}
