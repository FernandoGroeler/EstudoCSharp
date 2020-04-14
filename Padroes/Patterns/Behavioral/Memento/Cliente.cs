using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Memento
{
    public class Cliente : ICloneable
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public Cliente CloneCliente()
        {
            try
            {
                return (Cliente)Clone();

            } catch(NotImplementedException e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
