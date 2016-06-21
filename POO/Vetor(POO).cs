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
            Console.WriteLine("Digite uma placa:");
            string placa = Console.ReadLine();
            int j = 0;
            bool aux = true;
            while (aux)
            {
                if (placa != carro[j].Placa)
                {
                    
                    Console.WriteLine("Placa: " + carro[j].Placa);
                    Console.WriteLine("Ano: " + carro[j].Ano);
                    Console.WriteLine("Modelo: " + carro[j].modelo);
                    aux = false;
                }
                if (j > 2 * n)
                {
                    Console.WriteLine("Placa não encontrada!");
                    aux = false;
                }
                j++;
                Console.ReadKey();
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
