using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Visitor
{
    public class SelecionadorFesta : Tocador, IVisitorMusica
    {
        public void Visit(Musica musica)
        {
            switch (musica.TipoMusica)
            {
                case TipoMusica.DANCE:
                    break;
                case TipoMusica.POP:
                    lista.Add(musica);
                    break;
                default:
                    break;
            }
        }

        public override void Tocar()
        {
            lista.Shuffle();
            base.Tocar();
        }
    }
}
