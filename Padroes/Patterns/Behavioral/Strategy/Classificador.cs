using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Strategy
{
    public class Classificador
    {
        private IEstrategia _estrategia = null;
        private readonly List<Aluno> _alunos;

        public Classificador()
        {
            _alunos = new List<Aluno>();
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                Aluno aluno = new Aluno($"Aluno {i + 1}", random.Next(100), random.Next(10));

                _alunos.Add(aluno);
            }
        }

        public void SetEstrategia(IEstrategia estrategia)
        {
            _estrategia = estrategia;
        }

        public Aluno GetMelhorAluno()
        {
            if (_estrategia == null)
                throw new SystemException("Estratégia não definida.");

            return _estrategia.GetMelhorAluno(_alunos);
        }
    }
}
