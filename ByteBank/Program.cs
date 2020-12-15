using ByteBank.Funcionarios;
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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Auxiliar("546.879.157-20");
            carlos.Nome = "Carlos";

            Diretor roberta = new Diretor("454.658.48-3"); 
            roberta.Nome = "Roberta";

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            
            Console.ReadLine();
        }
    }
}
