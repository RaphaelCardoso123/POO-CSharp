using System;
using System.Collections.Generic;
using System.Text;

namespace Livros
{
    class Livro
    {

        public string NomeLivro { get; set; }

        public List<Autor> Autores = new List<Autor>();

    }
}
