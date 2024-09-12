using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_05___1___ATV
{        
    public class Livro
    {
        public string Nome { get; set; }
        public string Editora { get; set; }
        public string Autor { get; set; }
        public int NumeroDePaginas { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Editora: {Editora}, Autor: {Autor}, Número de Páginas: {NumeroDePaginas}";
        }
    }
}

