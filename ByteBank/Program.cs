using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {

        static void Main(string[] args)
        {

            Cliente martin = new Cliente("Martin", "Obrecht", "552.568.898-30", 21011989);
            martin.Endereco = "Rua Fidalga, 180 - Centro";
            martin.Profissao = "Engenheiro de Software";
            martin.Renda = 11000;

            try
            {
                ContaCorrente conta = new ContaCorrente(martin, 455, 18665);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }

            try
            {
                ContaCorrente conta1 = new ContaCorrente(martin, 4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(martin , 456794, 788854);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }

            Console.ReadLine();

        }                    
    }
}