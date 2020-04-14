using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Mediator
{
    public abstract class Cliente
    {
        private readonly IMediator _mediator;

        protected Cliente(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Send(string msg)
        {
            _mediator.Enviar(msg, this);
        }

        public IMediator GetMediator()
        {
            return _mediator;
        }

        public abstract void Receber(string msg);
    }
}
