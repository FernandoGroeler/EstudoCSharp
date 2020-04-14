using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Interpreter
{
    public class Numero : IExpressao
    {
        private readonly int _numero;

        public Numero(int numero)
        {
            _numero = numero;
        }

        public Numero(string numero)
        {
            _numero = int.Parse(numero);
        }

        public int Interpreter(Dictionary<string, IExpressao> variaveis)
        {
            return _numero;
        }
    }
}
