using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaLP
{
    class Livro
    {
        public string nomeLivro { get; set; }
        public string autor { get; set; }
        public string genero { get; set; }
        public string id_livro { get; set; }
        public int quantidade { get; set; }
        public double preco { get; set; }
    }
}
