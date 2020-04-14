using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.TemplateMethod
{
    public static class TestTemplateMethod
    {
        public static void Testar()
        {
            BaseReport baseReport = new ListaDeClientes();
            Console.WriteLine(baseReport.Imprimir());

            Console.WriteLine("\n\n\n\n");


            BaseReport baseReport1 = new RelatorioVendas();
            Console.WriteLine(baseReport1.Imprimir());
        }
    }
}
