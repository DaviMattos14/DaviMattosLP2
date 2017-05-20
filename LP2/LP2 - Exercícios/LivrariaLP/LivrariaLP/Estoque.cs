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
                int aux = 0;
                if (isbn == livros[i].Id_livro)
                {
                    Console.WriteLine("Nome: " + livros[i].NomeLivro);
                    Console.WriteLine("Autor: " + livros[i].Autor);
                    Console.WriteLine("ISBN: " + livros[i].Id_livro);
                    i = livros.Count;
                    aux++;
                }
                if (i == livros.Count && aux == 0)
                {
                    Console.WriteLine("Livro não encontrado!");
                }
            }
        }
    }
}
