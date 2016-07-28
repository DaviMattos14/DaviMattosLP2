using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaLP
{
    class Estoque
    {
        private List<Livro> livros;
        public Estoque()
        {
            this.livros = new List<Livro>();
        }
        public void AdicionarEstoque(Livro livro)
        {
            this.livros.Add(livro);
        }

        public void Consultar()
        {
            Console.Clear();
            Console.WriteLine("ISBN: ");
            string isbn = Console.ReadLine();
            for (int i = 0; i < livros.Count; i++)
            {
                if (isbn != livros[i].id_livro)
                {
                    Console.WriteLine("Nome: " + livros[i].nomeLivro);
                    Console.WriteLine("Autor: " + livros[i].autor);
                    Console.WriteLine("ISBN: " + livros[i].id_livro);
                    i = livros.Count;
                }
                if (i > 2 * livros.Count)
                {
                    Console.WriteLine("Livro não encontrado!");
                }
            }
        }
    }
}
