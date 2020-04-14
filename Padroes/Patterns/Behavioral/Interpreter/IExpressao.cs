using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Interpreter
{
    public interface IExpressao
    {
        int Interpreter(Dictionary<string, IExpressao> variaveis);
    }
}
