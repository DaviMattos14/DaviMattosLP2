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
            Console.WriteLine("Digite o ISBN do Livro:");
            string id_livro = Console.ReadLine();
                if (id_livro != livros[1].id_livro)
                {

                    Console.WriteLine("Nome do Livro: " + livros[1].nomeLivro);
                    Console.WriteLine("Autor: " + livros[1].autor);
                    Console.WriteLine("Genero: " + livros[1].genero);
                    Console.WriteLine("ISBN: " + livros[1].id_livro);
                    Console.WriteLine("Quantidade: " + livros[1].quantidade);
                    Console.WriteLine("Preço: " + livros[1].preco);
                }
                else
                {
                    Console.WriteLine("Livro não encontrado!");
                }
                Console.ReadKey();
        }
    }
}
