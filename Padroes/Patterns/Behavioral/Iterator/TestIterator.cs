using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Iterator
{
    public static class TestIterator
    {
        public static void Testar()
        {
            IIterator<int> it = new ListaDeNumeros();

            while(it.HasNext())
                Console.WriteLine(it.Next());
        }
    }
}
