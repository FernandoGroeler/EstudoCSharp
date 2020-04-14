using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.State
{
    public class NotaFiscal
    {
        private EnumEstado _estado = EnumEstado.NOVA;
        private List<string> _itens;

        public void Abrir()
        {
            if (_estado == EnumEstado.ABERTA)
                throw new SystemException("Nota já aberta.");

            if (_estado == EnumEstado.FECHADA)
                throw new SystemException("Nota já fechada.");

            _itens = new List<string>();
            _estado = EnumEstado.ABERTA;
        }

        public void AdicionarItem(string item)
        {
            if (_estado == EnumEstado.NOVA)
                throw new SystemException("Precisa abrir a nota.");

            if (_estado == EnumEstado.FECHADA)
                throw new SystemException("Nota já fechada.");

            _itens.Add(item);
        }

        public void Fechar()
        {
            if (_estado == EnumEstado.FECHADA)
                throw new SystemException("Nota já fechada.");

            _estado = EnumEstado.FECHADA;
        }
    }
}
