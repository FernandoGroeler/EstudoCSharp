using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Interpreter
{
    public static class TestInterpreter
    {
        public static void Testar()
        {
            string expressao = "a b + c +";

            Avaliador avaliador = new Avaliador(expressao);

            Dictionary<string, IExpressao> vars = new Dictionary<string, IExpressao>();

            vars.Add("a", new Numero(2));
            vars.Add("b", new Numero(4));
            vars.Add("c", new Numero(6));

            int resultado = avaliador.Interpreter(vars);

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
