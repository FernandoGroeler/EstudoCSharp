using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.Prototype
{
    public class Configuracao : ICloneable
    {
        public Configuracao()
        {
            try
            {
                Thread.Sleep(3000);
            }catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

            Random random = new Random();

            Numero = random.Next(100);
        }

        public decimal Numero { get; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
