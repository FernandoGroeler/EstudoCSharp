using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Interpreter
{
    public class Avaliador : IExpressao
    {
        private readonly IExpressao _expressaoCompleta;

        public Avaliador(string expression)
        {
            Stack<IExpressao> pilha = new Stack<IExpressao>();

            foreach (string token in expression.Split(' '))
            {
                Regex regex = new Regex("[0-9]+");

                if (token.Equals("+"))
                {
                    IExpressao subExpressao = new Adicao(pilha.Pop(), pilha.Pop());
                    pilha.Push(subExpressao);
                } else if (token.Equals("-"))
                {
                    IExpressao right = pilha.Pop();
                    IExpressao left = pilha.Pop();

                    IExpressao subExpressao = new Subtracao(left, right);
                    pilha.Push(subExpressao);
                } else if (Matches("[0-9]+", token))
                {
                    pilha.Push(new Numero(int.Parse(token)));
                } else if (Matches("[abcde]+", token))
                {
                    pilha.Push(new Variavel(token));
                } else
                {
                    throw new Exception("Erro na expressão.");
                }
            }

            _expressaoCompleta = pilha.Pop();
        }

        public int Interpreter(Dictionary<string, IExpressao> contexto)
        {
            return _expressaoCompleta.Interpreter(contexto);
        }

        private bool Matches(string regexExpression, string input)
        {
            Regex regex = new Regex(regexExpression);

            return regex.IsMatch(input);
        }
    }
}
