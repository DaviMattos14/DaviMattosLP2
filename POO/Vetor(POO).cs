using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            List<Carros> carro = new List<Carros>();
            for (int i = 0; i < n; i++)
            {
                Carros c = new Carros();
                c.Placa = Console.ReadLine();
                c.Ano = int.Parse(Console.ReadLine());
                c.modelo = Console.ReadLine();
                carro.Add(c);
            }

        }
    }
    class Carros
    {
        public string Placa { set; get; }
        public int Ano { set; get; }
        public string modelo { set; get; }

    }
}
