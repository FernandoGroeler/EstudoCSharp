using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Strategy
{
    public static class TestStrategy
    {
        public static void Testar()
        {
            Classificador classificador = new Classificador();

            classificador.SetEstrategia(new MelhorNota());
            Aluno aluno = classificador.GetMelhorAluno();
            Console.WriteLine($"Melhor nota: {aluno}");

            classificador.SetEstrategia(new MenosFalta());
            aluno = classificador.GetMelhorAluno();
            Console.WriteLine($"Menos falta: {aluno}");

            classificador.SetEstrategia(new MelhorNotaMenosFalta());
            aluno = classificador.GetMelhorAluno();
            Console.WriteLine($"Melhor nota e menos falta: {aluno}");
        }
    }
}
