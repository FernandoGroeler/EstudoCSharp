using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Observer
{
    public class ObserverGravarMensagem : IObserver<string>
    {
        private string _str;

        public ObserverGravarMensagem(string str)
        {
            _str = str;
        }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(string value)
        {
            _str = $"Gravando: {value}";
            Console.WriteLine(_str);
        }
    }
}
