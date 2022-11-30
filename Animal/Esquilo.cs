using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Esquilo : AnimalAbstract
    {

        public string gritar { get; set; }

        public override void ResumoAnimal()
        {
            base.ResumoAnimal();
            Console.WriteLine($"Tipo sonoro: {gritar}");
        }

        public override void TipoAnimal()
        {
            Console.WriteLine("Esquilo:");
        }

    }
}
