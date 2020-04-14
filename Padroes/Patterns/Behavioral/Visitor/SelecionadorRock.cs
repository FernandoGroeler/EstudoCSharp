using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Visitor
{
    public class SelecionadorRock : Tocador, IVisitorMusica
    {
        public void Visit(Musica musica)
        {
            if (musica.TipoMusica == TipoMusica.ROCK)
                lista.Add(musica);
        }
    }
}
