using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dataNascimento = new DateTime(2020, 11, 11);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataCorrente - dataNascimento;


            string mensagem = "Nasceu há " + TimeSpanHumanizeExtensions.Humanize(diferenca) ;

            Console.WriteLine(mensagem);

            Console.ReadLine();
            
        }
    }
}
