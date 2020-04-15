using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Creational.Singleton
{
    public class MeuSingleton
    {
        private static MeuSingleton _self;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static MeuSingleton GetInstance()
        {
            if (_self == null)
                _self = new MeuSingleton();

            return _self;
        }
    }
}
