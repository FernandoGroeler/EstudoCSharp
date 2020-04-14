using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Strategy
{
    public class MelhorNota : IEstrategia
    {
        public Aluno GetMelhorAluno(List<Aluno> alunos)
        {
            Aluno melhor = null;

            foreach (Aluno aluno in alunos)
            {
                if (melhor == null)
                    melhor = aluno;
                else if (aluno.Nota > melhor.Nota)
                    melhor = aluno;
            }

            return melhor;
        }
    }
}
