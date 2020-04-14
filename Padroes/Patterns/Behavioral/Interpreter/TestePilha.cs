using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Interpreter
{
    public static class TestePilha
    {
        public static void Testar()
        {
            Stack<int> pilha = new Stack<int>();

            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);

            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Pop());
        }
    }
}
