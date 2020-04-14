using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.TemplateMethod
{
    public abstract class BaseReport
    {
        public string Imprimir()
        {
            char[] line = new char[80];

            for (int i = 0; i < line.Length; i++)
                line[i] = '-';

            StringBuilder sb = new StringBuilder();
            sb.Append(line).Append('\n');
            sb.Append(DateTime.Now).Append('\n');
            sb.Append(line).Append("\n");
            sb.Append(GetCabecalho()).Append('\n');
            sb.Append(line).Append('\n');
            sb.Append(GetCorpo()).Append('\n');
            sb.Append(line).Append('\n');
            sb.Append(GetRodape()).Append('\n');
            sb.Append(line).Append('\n');

            return sb.ToString();
        }

        public abstract string GetCabecalho();

        public abstract string GetCorpo();

        public abstract string GetRodape();
    }
}
