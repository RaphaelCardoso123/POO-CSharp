using System;

namespace Conta
{
    class ContaCorrente : ContaAbstract
    {

        public double Tarifa { get; set; }



        public override void ExibirResumoConta()
        {
            base.ExibirResumoConta(); 
            Console.WriteLine($"Tarifa: {Tarifa}.");
        }
        public override void ExibirTipoDeConta()
        {
            Console.WriteLine("Conta Corrente.");
        }

    }
}
