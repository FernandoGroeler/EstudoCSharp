using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Visitor
{
    public class BibliotecaDeMusica
    {
        private List<Musica> _musicas;

        public BibliotecaDeMusica()
        {
            _musicas = CarregarBancoDeDados();
        }

        private static TipoMusica RandomMusic()
        {
            Random random = new Random();

            int j = random.Next(5);
            var values = Enum.GetValues(typeof(TipoMusica)).Cast<TipoMusica>().ToList();

            int i = values.Count();

            return values[j >= i ? j - 1 : j];
        }

        private List<Musica> CarregarBancoDeDados()
        {
            List<Musica> lista = new List<Musica>();

            for (int i = 0; i < 1000; i++)
            {
                TipoMusica tipo = RandomMusic();

                string nome = $"Nome {tipo} {i}";
                string album = $"Album {tipo} {i}";
                string artista = $"Artista {tipo} {i}";

                Musica musica = new Musica(tipo, nome, album, artista);
                lista.Add(musica);

                Console.WriteLine($"Criando {musica}");
            }

            return lista;
        }

        public void Accept(IVisitorMusica visitorMusica)
        {
            foreach (Musica musica in _musicas)
                visitorMusica.Visit(musica);
        }
    }
}
