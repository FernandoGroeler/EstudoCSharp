using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.State
{
    public static class TestState
    {
        public static void Testar()
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.Abrir();

            notaFiscal.AdicionarItem("Leite");
            notaFiscal.AdicionarItem("Arroz");
            notaFiscal.AdicionarItem("Feijão");

            notaFiscal.Fechar();
        }
    }
}
