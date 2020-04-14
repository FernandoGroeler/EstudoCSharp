using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Observer
{
    public static class TestObserver
    {    
        public static void Testar()
        {
            LeitorDeComandos leitorDeComandos = new LeitorDeComandos();

            ObserverGravarMensagem observerGravarMensagem = new ObserverGravarMensagem(string.Empty);
            ObserverMostrarMensagem observerMostrarMensagem = new ObserverMostrarMensagem(string.Empty);

            leitorDeComandos.Subscribe(observerGravarMensagem);
            leitorDeComandos.Subscribe(observerMostrarMensagem);
            
            leitorDeComandos.Changed("Teste observer");
        }
    }
}
