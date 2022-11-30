using System;
using System.Collections.Generic;
using System.Text;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONTA CORRENTE
            ContaCorrente contaC = new ContaCorrente();
            contaC.Nome = "Raphael Cardoso";
            contaC.Numero = 9999;
            contaC.Agencia = 123;
            contaC.Tarifa = 15;
            contaC.Depositar(1000);  //pelo Saldo na classe Conta ser privado só pode ser alterada dessa maneira.
            contaC.Sacar(900);       //pelo Saldo na classe Conta ser privado só pode ser alterada dessa maneira.
            contaC.ExibirTipoDeConta();  //Usando Polimorfismo
            contaC.ExibirResumoConta();
            Console.WriteLine("----------------------");
            //CONTA POUPANÇA
            ContaPoupanca contaP = new ContaPoupanca();
            contaP.Nome = "Flávia Gimmioli";
            contaP.Numero = 8888;
            contaP.Agencia = 321;
            contaP.Juros = 2;
            contaP.Depositar(1200); //pelo Saldo na classe Conta ser privado só pode ser alterada dessa maneira.
            contaP.Sacar(800);      //pelo Saldo na classe Conta ser privado só pode ser alterada dessa maneira.
            contaP.ExibirTipoDeConta();  //Usando Polimorfismo
            contaP.ExibirResumoConta();

            Console.ReadLine();

        }
    }
}
