using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Livro
    {
        private List<Livro> Livros;
        public string nomeLivro { get; set; }
        public int id_Livro { get; set; }
        public string genero { get; set; }
        public string autor { get; set; }
        public int quantidade { get; set; }
        public double preço { get; set; }

        public void Livro()
        {
            this.Livros = new List<Livro>();
        }
        public void Estoque(Livro livro)
        {
            this.Livros.Add(livro);
        }
        public void Cadastrar()
        {
            Console.Clear();
            Console.Write("Nome: ");
            nomeLivro = Console.ReadLine();
            Console.Write("ISBN: ");
            id_Livro = int.Parse(Console.ReadLine());
        }
        public void Consultar()
        {

        }
        public void Alterar()
        {

        }
        public void Remover()
        {

        }
    }
}
