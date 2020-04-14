using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.TemplateMethod
{
    public class ListaDeClientes : BaseReport
    {
        public override string GetCabecalho()
        {
            return "Lista de clientes";
        }

        public override string GetCorpo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hugo").Append('\n');
            sb.Append("Jose").Append('\n');
            sb.Append("Luiz").Append('\n');
            return sb.ToString();
        }

        public override string GetRodape()
        {
            return "Gerado por MySystem";
        }
    }
}
