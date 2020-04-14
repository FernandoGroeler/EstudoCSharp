using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Interpreter
{
    public class Variavel : IExpressao
    {
        private readonly string _nome;

        public Variavel(string nome)
        {
            _nome = nome;
        }

        public int Interpreter(Dictionary<string, IExpressao> variaveis)
        {            
            variaveis.TryGetValue(_nome, out IExpressao value);

            if (value == null)
                throw new ArgumentNullException($"Variável {_nome} sem atribuição.");

            return value.Interpreter(variaveis);
        }
    }
}
