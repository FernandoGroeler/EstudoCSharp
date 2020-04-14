using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Mediator
{
    public class Servidor : IMediator
    {
        private List<Cliente> _clientes;

        public Servidor()
        {
            _clientes = new List<Cliente>();
        }

        public void Enviar(string msg, Cliente origem)
        {
            foreach (var cliente in _clientes)
            {
                if (cliente != origem)
                    cliente.Receber(msg);
            }
        }

        public void AddCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
        }
    }
}
