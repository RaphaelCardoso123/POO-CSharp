using System;

namespace Livros
{
    class Program
    {
        static void Main(string[] args)
        {

            Livro livro1 = new Livro();
            livro1.NomeLivro = "The catcher in the Rye";
            Livro livro2 = new Livro();
            livro2.NomeLivro = "Rich Dad Poor Dad";
            Livro livro3 = new Livro();
            livro3.NomeLivro = "Richest Man in Babylon";


            Autor autor1 = new Autor();
            autor1.Nome = "J. D. Salinger";
            autor1.Email = "salinger@gmail.com";

            Autor autor2 = new Autor();
            autor2.Nome = "Robert Kiyosaki";
            autor2.Email = "robert@hotmail.com";

            Autor autor3 = new Autor();
            autor3.Nome = "George Samuel Clason ";
            autor3.Email = "george@gmail.com";


            livro1.Autores.Add(autor1);
            livro2.Autores.Add(autor2);
            livro3.Autores.Add(autor3);


            Console.WriteLine("Livros:");
            Console.WriteLine("");

            Console.WriteLine(livro1.NomeLivro);
            foreach (Autor obj in livro1.Autores)
            {
                Console.WriteLine($"Autor: {obj.Nome}.");
                Console.WriteLine($"Email: {obj.Email}.");
                Console.WriteLine("");
            }

            Console.WriteLine(livro2.NomeLivro);
            foreach (Autor obj in livro2.Autores)
            {
                Console.WriteLine($"Autor: {obj.Nome}.");
                Console.WriteLine($"Email: {obj.Email}.");
                Console.WriteLine("");
            }

            Console.WriteLine(livro3.NomeLivro);
            foreach (Autor obj in livro3.Autores)
            {
                Console.WriteLine($"Autor: {obj.Nome}.");
                Console.WriteLine($"Email: {obj.Email}.");
                Console.WriteLine("");
            }


            Console.ReadLine();

        }
    }
}
