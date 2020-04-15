using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.Prototype
{
    public static class TestPrototype
    {
        public static void Testar()
        {
            Console.WriteLine("Instancia 1");
            Configuracao configuracao1 = new Configuracao();
            Console.WriteLine($"Instanciou 1 {configuracao1.Numero}");

            Console.WriteLine("Instancia 2");
            Configuracao configuracao2 = new Configuracao();
            Console.WriteLine($"Instanciou 2 {configuracao2.Numero}");

            Console.WriteLine("Instancia 3");
            Configuracao configuracao3 = null;
            try
            {
                configuracao3 = (Configuracao)configuracao1.Clone();
            } catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"Instanciou 3 {configuracao3.Numero}");

            Console.WriteLine(configuracao1 == configuracao2);
            Console.WriteLine(configuracao1 == configuracao3);
        }
    }
}
