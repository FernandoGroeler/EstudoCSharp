﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Mediator
{
    public class ClienteRemoto : Cliente
    {
        public ClienteRemoto(IMediator mediator) : base(mediator)
        {
        }

        public override void Receber(string msg)
        {
            Console.WriteLine($"Client remoto recebeu: {msg}.");
        }
    }
}
