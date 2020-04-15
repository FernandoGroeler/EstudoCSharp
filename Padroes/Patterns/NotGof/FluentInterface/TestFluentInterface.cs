using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.NotGof.FluentInterface
{
    public static class TestFluentInterface
    {
        public static void Testar()
        {
            ConstrutorCarro construtorCarro = new ConstrutorCarro();
            construtorCarro.Id(1)
                .Cor("Azul")
                .Ano("2020")
                .Ar("Sim")
                .Direcao("Sim")
                .Marca("VW")
                .Modelo("Qualquer")
                .Construir();

            Console.WriteLine(construtorCarro.ToString());
        }
    }
}
