using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.AbstractFactory
{
    public static class TestAbstractFactory
    {
        private const int _windows = 0;
        private const int _macOsx = 1;

        private static IGUIFactory CriarFactory()
        {
            int sistema = _windows;

            if (sistema == _windows)
                return new WindowsFactory();
            else if (sistema == _macOsx)
                return new OSXFactory();

            throw new SystemException("Sistema não suportado");
        }

        public static void Testar()
        {
            new Aplicacao(CriarFactory());
        }
    }
}
