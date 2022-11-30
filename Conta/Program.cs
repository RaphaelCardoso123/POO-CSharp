using System;
using System.Collections.Generic;
using System.Text;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaC = new ContaCorrente();
            contaC.Nome = "Raphael Cardoso";
            contaC.Numero = 9999;
            contaC.Agencia = 123;
            contaC.Tarifa = 15;
            contaC.Depositar(1000);  
            contaC.Sacar(900);       
            contaC.ExibirTipoDeConta(); 
            contaC.ExibirResumoConta();
            Console.WriteLine("----------------------");


            ContaPoupanca contaP = new ContaPoupanca();
            contaP.Nome = "Flávia Gimmioli";
            contaP.Numero = 8888;
            contaP.Agencia = 321;
            contaP.Juros = 2;
            contaP.Depositar(1200);
            contaP.Sacar(800);     
            contaP.ExibirTipoDeConta(); 
            contaP.ExibirResumoConta();

            Console.ReadLine();

        }
    }
}
