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
            Menu();//
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu: \n 1.Cadastrar \n 2.Consultar \n 3.Alterar \n 4.Remover \n 5.Sair \n ----------");
            int menu = int.Parse(Console.ReadLine());
            Livro l = new Livro();
            Estoque e = new Estoque();
            /* Cadastrar*/
            ;
            if (menu == 1)
            {
                Cadastrar();//
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
            /* Sair */
            if (menu == 5) { }
        }

        private static void Cadastrar()
        {
            Estoque e = new Estoque();
            Console.Clear();
            Console.WriteLine("Cadastrar quantos livros?");
            int livrosCadastrar = int.Parse(Console.ReadLine());
            for (int i = 0; i < livrosCadastrar; i++)
            {
                Livro l = new Livro();
                Console.Clear();
                Console.Write("Nome do livro: ");
                l.NomeLivro = Console.ReadLine();
                Console.Write("Autor: ");
                l.Autor = Console.ReadLine();
                //Console.Write("Genero: ");
                //l.Genero = Console.ReadLine();
                Console.Write("ISBN: ");
                l.Id_livro = Console.ReadLine();
                //Console.Write("Quantidade: ");
                //l.Quantidade = int.Parse(Console.ReadLine());
                //Console.Write("Preço: ");
                //l.Preco = double.Parse(Console.ReadLine());
                e.AdicionarEstoque(l);
            }
            e.Consultar();
            Console.WriteLine("\n Cadastrar mais livros? 1- Sim 2- não");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
                Cadastrar();
            else
                Menu();//
        }
    }
}
    

    
