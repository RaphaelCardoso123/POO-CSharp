using System;
using System.Globalization;

namespace Conta
{
    class ContaCorrente
    {
        public string Nome { get; set; }
        public int Conta { get; private set; }
        public int Agencia { get; private set; }
        private double Saldo { get; set; }


        public ContaCorrente(string nome, int conta, int agencia, double saldo)
        {
            Nome = nome;
            Conta = conta;
            Agencia = agencia;
            Saldo = saldo;
        }


        public ContaCorrente()
        {
        }


        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }


        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!!!");
            }
        }


        public override string ToString()
        {
            return "Nome: "
                + Nome
                + ", Conta:"
                + Conta
                + ", Agencia: "
                + Agencia
                + ", Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
