using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Visitor
{
    public static class TestVisitor
    {
        public static void Testar()
        {
            BibliotecaDeMusica bibliotecaDeMusica = new BibliotecaDeMusica();

            Console.WriteLine("\n\n-----------------------------\n\n");

            SelecionadorRock selecionadorRock = new SelecionadorRock();
            bibliotecaDeMusica.Accept(selecionadorRock);
            selecionadorRock.Tocar();
            Console.WriteLine("\n\n-----------------------------\n\n");

            SelecionadorFesta selecionadorFesta = new SelecionadorFesta();
            bibliotecaDeMusica.Accept(selecionadorFesta);
            selecionadorFesta.Tocar();
            Console.WriteLine("\n\n-----------------------------\n\n");
        }
    }
}
