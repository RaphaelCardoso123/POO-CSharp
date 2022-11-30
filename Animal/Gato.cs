using System;

namespace Animal
{
    class Gato : AnimalAbstract
    {

        public string Miar { get; set; }

        public override void ResumoAnimal()
        {
            base.ResumoAnimal();
            Console.WriteLine($"Gato: {Miar}");
        }
        public override void TipoAnimal()
        {
            Console.WriteLine("Gato:");
        }

    }
}
