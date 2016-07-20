using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu: \n 1. Cadastrar \n 2. Consultar \n 3. Alterar \n 4. Remover \n 5. Sair \n ----------- ");
            int menu = int.Parse(Console.ReadLine());
            Estoque e = new Estoque();
            if (menu == 1)
                e.Cadastrar();
            if (menu == 2)
                e.Consultar();
            if (menu == 3)
                e.Alterar();
            if (menu == 4)
                e.Remover();
            if (menu == 5)
                Environment.Exit(menu);
        }
    }
}
