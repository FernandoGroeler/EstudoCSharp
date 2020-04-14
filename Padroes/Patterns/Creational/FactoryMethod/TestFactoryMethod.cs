using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.FactoryMethod
{
    public static class TestFactoryMethod
    {
        public static void Testar()
        {
            INota nota = new NotaFactory().GetNota(EnumUF.PR);
            Console.WriteLine(nota.ToString());
        }
    }
}
