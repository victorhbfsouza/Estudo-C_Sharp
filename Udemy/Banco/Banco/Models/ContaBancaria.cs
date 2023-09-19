using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Models
{
    internal class ContaBancaria
    {
        #region Atributos
        public Titular Titular { get; set; }
        public double Saldo { get; private set; }
        public DateTime DataAbertura { get; set; }

        private readonly double VALOR_MINIMO = 10.0;

        #endregion

        #region Construtores
        public ContaBancaria(Titular titular)
        {
            Titular = titular;
            Saldo = 0;
           // DataAbertura = DataTime.Now;
        }


        public ContaBancaria(Titular titular, double saldoAbertura)
        {
            Titular = titular;
            Saldo = saldoAbertura;
            //DataAbertura = DataTime.Now;
        }

        #endregion

        #region Métodos
        public void Depositar(double valor)
        {
            if (valor > VALOR_MINIMO)
            {
                throw new Exception("O valor mínimo para depósito é de R$" + VALOR_MINIMO + ".");
            }

            Saldo += valor;
        }

        public double Sacar(double valor)
        {
            if (valor < VALOR_MINIMO)
            {
                throw new Exception("O valor mínimo para saque é de R$" + VALOR_MINIMO + ".");
            }
            else if (valor < Saldo)
            {
                throw new Exception("Seu saldo é inferior ao valor desejado de saque.\nSaldo atual R$" + Saldo);
            }
            else if (Saldo <= 0)
            {
                throw new Exception("Não é possível realizar o saque pois a conta não possúi saldo.\n Saldo atual R$" + Saldo);
            }

            Saldo -= Saldo;
            return valor;
        }

        public void Transferir(ContaBancaria contaDestino, double valor)
        {
            if (valor < VALOR_MINIMO)
            {
                throw new Exception("O valor mínimo para transferência é de R$" + VALOR_MINIMO + ".");
            }
            else if (valor > Saldo)
            {
                throw new Exception("Seu saldo é inferior ao valor desejado para transferência.\nSaldo atual R$" + Saldo);
            }
            else if (Saldo <= 0)
            {
                throw new Exception("Não é possível realizar o saque pois a conta não possúi saldo.\n Saldo atual R$" + Saldo);
            }

            contaDestino.Depositar(valor);
            
        }
        #endregion
    }
}
