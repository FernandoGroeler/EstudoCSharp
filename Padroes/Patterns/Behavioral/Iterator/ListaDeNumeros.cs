using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Iterator
{
    public class ListaDeNumeros : IIterator<int>
    {
        private readonly int[] _arrayInt;
        private int _index;

        public ListaDeNumeros()
        {
            _arrayInt = new int[10];
            _index = -1;

            for (int i = 0; i < _arrayInt.Length; i++)
                _arrayInt[i] = i;

        }

        public bool HasNext()
        {
            return _index < _arrayInt.Length - 1;
        }

        public int Next()
        {
            _index++;
            return _arrayInt[_index];
        }
    }
}
