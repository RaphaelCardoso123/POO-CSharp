using System;

namespace Conta
{
    class ContaPoupanca : ContaAbstract
    {

        public double Juros { get; set; }



        public override void ExibirResumoConta()
        {
            base.ExibirResumoConta();
            Console.WriteLine($"Juros: {Juros}.");
        }
        public override void ExibirTipoDeConta()
        {
            Console.WriteLine("Conta Poupança.");
        }

    }
}
