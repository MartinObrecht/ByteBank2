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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao(); // Construtor

            Funcionario carlos = new Funcionario(); // Construtor
            carlos.Nome = "Carlos";
            carlos.CPF = "546.879.157-20";
            carlos.Salario = 2000;

            Diretor roberta = new Diretor();// Construtor
            roberta.Nome = "Roberta";
            roberta.CPF = "454.658.48-3";
            roberta.Salario = 5000;


            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            
            Console.ReadLine();
        }
    }
}
