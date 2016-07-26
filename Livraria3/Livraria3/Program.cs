using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> estoque = new List<Livro>();
            Console.WriteLine("Menu: \n 1. Cadastrar \n 2. Consultar \n 3. Alterar \n 4. Remover \n 5. Sair \n ----------- ");
            int menu = int.Parse(Console.ReadLine());
            Livro l = new Livro();
            Estoque e = new Estoque();
            if (menu == 1)
            {
                Console.Clear();
                Console.Write("Nome do livro: ");
                estoque.Add(new Livro() { nomeLivro = Console.ReadLine() });
                Console.Write("Autor: ");
                estoque.Add(new Livro() { autor = Console.ReadLine() });
                estoque.Add(l);
                Console.Clear();
                foreach (Livro livro in estoque)
                {
                    Console.WriteLine(livro);
                }
            }
            if (menu == 2)
                //l.Consultar();
            if (menu == 3)
                //l.Alterar();
            if (menu == 4)
                //l.Remover();
            if (menu == 5) { }
        }
    }
}
