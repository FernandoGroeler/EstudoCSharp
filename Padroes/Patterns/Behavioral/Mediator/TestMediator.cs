using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Mediator
{
    public static class TestMediator
    {
        public static void Testar()
        {
            Servidor servidor = new Servidor();

            Cliente local = new ClienteLocal(servidor);
            Cliente remoto = new ClienteRemoto(servidor);
            Cliente movel = new ClienteMovel(servidor);

            servidor.AddCliente(local);
            servidor.AddCliente(remoto);
            servidor.AddCliente(movel);

            Console.WriteLine("Cliente local enviando.");
            local.Send("Olá do cliente local.");

            Console.WriteLine("\nCliente remoto enviando.");
            remoto.Send("Olá do cliente remoto.");

            Console.WriteLine("\nCliente movel enviando.");
            movel.Send("Olá do cliente movel.");
        }
    }
}
