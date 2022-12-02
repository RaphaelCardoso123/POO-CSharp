﻿using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {

            Cachorro cachorro = new Cachorro();
            cachorro.TipoAnimal();
            cachorro.Raca = "Pastor Alemão";
            cachorro.Tamanho = "Grande";
            cachorro.Latir = "AuAuuu!!";
            cachorro.ResumoAnimal();

            Console.WriteLine("");

            Gato gato = new Gato();
            gato.TipoAnimal();
            gato.Raca = "Azul Russo";
            gato.Tamanho = "Médio";
            gato.Miar = "Miaaaau!!";
            gato.ResumoAnimal();

            Console.WriteLine("");

            Passaro passaro = new Passaro();
            passaro.TipoAnimal();
            passaro.Raca = "Andorinha";
            passaro.Tamanho = "Pequeno";
            passaro.Piar = "PiuPiuPiu!!";
            passaro.ResumoAnimal();
            
            

            Console.ReadLine();

        }
    }
}
