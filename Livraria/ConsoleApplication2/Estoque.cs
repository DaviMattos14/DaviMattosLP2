using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Estoque
    {
        public string nomeLivro { get; set; }
        public int isbnLivro { get; set; }
        public void Cadastrar()
        {
            Console.Clear();
            Console.Write("Nome: ");
            nomeLivro = Console.ReadLine();
            Console.Write("ISBN: ");
            isbnLivro = int.Parse(Console.ReadLine());
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
