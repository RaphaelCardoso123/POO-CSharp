using System;

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
