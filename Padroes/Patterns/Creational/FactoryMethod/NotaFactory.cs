using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.FactoryMethod
{
    public class NotaFactory
    {
        public INota GetNota(EnumUF uf)
        {
            switch (uf)
            {
                case EnumUF.PR:
                    return new NotaPR();
                case EnumUF.SP:
                    return new NotaSP();
                default:
                    throw new SystemException("Estado não suportado.");
            }
        }
    }
}
