using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Interpreter
{
    public class Subtracao : IExpressao
    {
        private readonly IExpressao _operadorEsquerdo;
        private readonly IExpressao _operadorDireito;

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            _operadorEsquerdo = esquerda;
            _operadorDireito = direita;
        }

        public int Interpreter(Dictionary<string, IExpressao> variaveis)
        {
            return _operadorEsquerdo.Interpreter(variaveis) - _operadorDireito.Interpreter(variaveis);
        }
    }
}
