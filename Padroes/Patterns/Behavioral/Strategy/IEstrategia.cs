using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Strategy
{
    public interface IEstrategia
    {
        Aluno GetMelhorAluno(List<Aluno> alunos);
    }
}
