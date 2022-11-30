using System;
using System.Collections.Generic;
using System.Text;

namespace Conta
{
    class ContaCorrente : ContaAbstract
    {

        public double Tarifa { get; set; }


        //Polimorfismo (Override)
        public override void ExibirResumoConta()
        {
            base.ExibirResumoConta(); // Quando usa (base.) é para chamar dados da "base" neste caso "Conta" + a Tarifa
            Console.WriteLine($"Tarifa: {Tarifa}.");
        }
        public override void ExibirTipoDeConta()
        {
            Console.WriteLine("Conta Corrente."); // Aqui ñ usou (base.) pq é p/ usar somente o "Conta Corrente"
        }

    }
}
