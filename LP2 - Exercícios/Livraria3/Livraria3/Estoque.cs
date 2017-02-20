using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria3
{
    class Estoque
    {
        public List<Livro> Livro = new List<Livro>();

        public void lista()
        {
            foreach (Livro book in Livro)
            {
                Console.WriteLine(book);
            }
        }
    }
}
