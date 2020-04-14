using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Visitor
{
    public class Musica
    {
        public Musica(TipoMusica tipoMusica, string nome, string album, string artista)
        {
            TipoMusica = tipoMusica;
            Nome = nome;
            Album = album;
            Artista = artista;
        }

        public TipoMusica TipoMusica { get; set; }
        public string Nome { get; set; }
        public string Album { get; set; }
        public string Artista { get; set; }

        public override string ToString()
        {
            return $"Música [tipo={TipoMusica}, nome={Nome}, album={Album}, artista={Artista}";
        }
    }
}
