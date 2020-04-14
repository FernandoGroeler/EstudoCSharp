using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Visitor
{
    public interface IVisitorMusica
    {
        void Visit(Musica item);
    }
}
