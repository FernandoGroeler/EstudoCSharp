using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.Builder
{
    public abstract class RelatorioBuilder
    {
        public abstract void Cabecalho();

        public abstract void Corpo();

        public abstract void Rodape();

        public Relatorio Relatorio { get; set; }
    }
}
