using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class AnimalAbstract
    {

        public string Raca { get; set; }
        public string Tamanho { get; set; }


        public virtual void TipoAnimal()
        {
            Console.WriteLine("Tipo animal:");
        }

        public virtual void ResumoAnimal()
        {
            Console.WriteLine($"Raça: {Raca}");
            Console.WriteLine($"Tamanho: {Tamanho}");
        }

    }
}
