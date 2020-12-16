using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public string Agencia { get; private set; }
        public string NumeroConta { get; private set; }
        public Cliente Cliente { get; private set; }
        private double _saldo = 0;

        public static int TotalContasCorrentes { get; private set; }

        public ContaCorrente(Cliente cliente, string agencia, string numeroconta)
        {
            Cliente = cliente;
            Agencia = agencia;
            NumeroConta = numeroconta;

            TotalContasCorrentes++;

        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                Console.WriteLine("Saldo Insuficiente.");
                return false;
            }
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}