using Conta;
using System;
class Program
{
    public static void Main()
    {
        ContaCorrente conta = new ContaCorrente("Raphael", 123, 2025, 3500.00);

        conta.Sacar(1000);
        conta.Depositar(3000);

        Console.WriteLine(conta);

        Console.ReadLine();
    }
}