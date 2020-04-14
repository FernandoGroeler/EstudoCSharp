using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.ChainOfResponsability
{
    public static class TestChainOfResponsability
    {
        public static void Testar()
        {
            Logger logger = new ConsoleLogger(Logger.DEBUG);

            Logger logger1 = logger.SetNext(new EmailLogger(Logger.INFO));

            logger1.SetNext(new ErrorLogger(Logger.ERRO));

            logger.Message("Executando busca.", Logger.DEBUG);

            logger.Message("Relatório gerado com sucesso.", Logger.INFO);

            logger.Message("Erro no processo.", Logger.ERRO);
        }
    }
}
