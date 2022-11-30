using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Passaro : AnimalAbstract
    {

        public string Piar { get; set; }

        public override void ResumoAnimal()
        {
            base.ResumoAnimal();
            Console.WriteLine($"Pássaro: {Piar}");
        }
        public override void TipoAnimal()
        {
            Console.WriteLine("Pássaro:");
        }

    }
}
