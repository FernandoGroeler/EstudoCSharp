using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Visitor
{
    public class Tocador
    {
        protected List<Musica> lista = new List<Musica>();

        public virtual void Tocar()
        {
            foreach (Musica musica in lista)
                Console.WriteLine($"Tocando: {musica}");
        }
    }
}
