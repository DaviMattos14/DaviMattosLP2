using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaLP
{
    class Program
    {
        static void Main(string[] args)
        {
        menu:
            Console.Clear();
            Console.WriteLine("Menu: \n 1.Cadastrar \n 2.Consultar \n 3.Alterar \n 4.Remover \n 5.Sair \n ----------");
            int menu = int.Parse(Console.ReadLine());
            Livro l = new Livro();
            Estoque e = new Estoque();
            /* Cadastrar*/
            ;
            if (menu == 1)
            {
            cadastrar:
                Console.Clear();
                Console.Write("Nome do livro: ");
                l.nomeLivro = Console.ReadLine();
                Console.Write("Autor: ");
                l.autor = Console.ReadLine();
                Console.Write("Genero: ");
                l.genero = Console.ReadLine();
                Console.Write("ISBN: ");
                l.id_livro = Console.ReadLine();
                Console.Write("Quantidade: ");
                l.quantidade = int.Parse(Console.ReadLine());
                Console.Write("Preço: ");
                l.preco = double.Parse(Console.ReadLine());
                e.AdicionarEstoque(l);
                Console.WriteLine("Cadastrar outro livro? 1- Sim 2- não");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                    goto cadastrar;
                if (opcao == 2)
                    goto menu;
            }
            /* Consultar*/
            if (menu == 2)
            {
                e.Consultar();
            }
            /* Alterar*/
            if (menu == 3)
            {
            }
            /* Remover*/
            if (menu == 4)
            {
            }
            /* */
            if (menu == 5) { }
        }
    }
}
