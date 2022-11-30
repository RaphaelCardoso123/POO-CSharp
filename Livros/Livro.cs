using System.Collections.Generic;


namespace Livros
{
    class Livro
    {

        public string NomeLivro { get; set; }

        public List<Autor> Autores = new List<Autor>();

    }
}
