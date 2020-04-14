using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Strategy
{
    public class Aluno
    {
        public Aluno(string nome, int nota, int faltas)
        {
            Nome = nome;
            Nota = nota;
            Faltas = faltas;

            Console.WriteLine(ToString());
        }

        public string Nome { get; set; }
        public int Nota { get; set; }
        public int Faltas { get; set; }

        public override string ToString()
        {
            return $"Aluno [nome={Nome}, notas={Nota}, faltas={Faltas}]";
        }
    }
}
