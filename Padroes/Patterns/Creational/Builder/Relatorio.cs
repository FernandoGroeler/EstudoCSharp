using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.Builder
{
    public class Relatorio
    {
        public string Cabecalho { get; set; }
        public string Corpo { get; set; }
        public string Rodape { get; set; }

        public override string ToString()
        {
            return $"{Cabecalho}\n{Corpo}\n{Rodape}";
        }
    }
}
