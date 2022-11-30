using System;

namespace Animal
{
    class Cachorro : AnimalAbstract
    {

        public string Latir { get; set; }

        public override void ResumoAnimal()
        {
            base.ResumoAnimal();
            Console.WriteLine($"Tipo sonoro: {Latir}");
        }

        public override void TipoAnimal()
        {
            Console.WriteLine("Cachorro:");
        }

    }
}
