using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        
        public int Agencia { get; }
        public int NumeroConta { get; }
        public Cliente Cliente { get; }
        private double _saldo = 500;

        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public static int TotalContasCorrentes { get; private set; }

        public ContaCorrente(Cliente cliente, int agencia, int numeroConta)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numeroConta <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numeroConta));
            }

            Cliente = cliente;
            Agencia = agencia;
            NumeroConta = numeroConta;

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

        public void Sacar(double valor)
        {

            if (_saldo < 0)
            {
                throw new ArgumentException("Valor de saque não pode ser negativo", nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(_saldo, valor);
            }
            _saldo -= valor;
        }
        public void Depositar(double valor)
        {
            _saldo += valor;
        }
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            contaDestino.Depositar(valor);
        }

    }
}