using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Cliente
    {
        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }
        public string CPF { get; private set; }
        public int DataNascimento { get; private set; }
        public string Endereco { get; set; }
        public string Profissao { get; set; }
        public double Renda { get; set; }
        public static int TotalClientes { get; private set; }


        public Cliente(string primeironome, string sobrenome, string cpf, int datanascimento)
        {
            PrimeiroNome = primeironome;
            SobreNome = sobrenome;
            CPF = cpf;
            DataNascimento = datanascimento;

            TotalClientes++;
        }

    }
}
