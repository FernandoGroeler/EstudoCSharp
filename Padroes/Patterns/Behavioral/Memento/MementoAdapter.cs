using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Memento
{
    public class MementoAdapter
    {
        private List<Cliente> _listaClientes = new List<Cliente>();
        private Cliente _clienteAtual;

        public MementoAdapter()
        {
        }

        public Cliente Anterior()
        {
            int index = _listaClientes.IndexOf(_clienteAtual);

            if (index == 0)
                throw new ArgumentNullException("Não há anterior.");

            _clienteAtual = _listaClientes[index - 1];

            return _clienteAtual;
        }

        public Cliente Proximo()
        {
            int index = _listaClientes.IndexOf(_clienteAtual);

            if (index == _listaClientes.Count() - 1)
                throw new ArgumentNullException("Não há próximo.");

            _clienteAtual = _listaClientes[index + 1];

            return _clienteAtual;
        }

        public Cliente Inicializar()
        {
            _clienteAtual = new Cliente();
            _listaClientes.Add(_clienteAtual);
            return _clienteAtual;
        }

        public Cliente Salvar()
        {
            int index = _listaClientes.IndexOf(_clienteAtual);

            if (index != _listaClientes.Count() - 1)
            {
                while (index < _listaClientes.Count() - 1)
                    _listaClientes.RemoveAt(index + 1);
            }

            _listaClientes.Add(_clienteAtual.CloneCliente());

            _clienteAtual = _listaClientes[_listaClientes.Count() - 1];

            return _clienteAtual;
        }
    }
}
