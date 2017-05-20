using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine());
            List<Ponto> pontos = new List<Ponto>();
            double xMedio = 0;
            double yMedio = 0;
            double distMedia = 0;
            for (int i = 0; i < qtd; i++)
            {
                Ponto p = new Ponto();
                Console.Write("X: ");
                p.x = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                p.y = int.Parse(Console.ReadLine());
                pontos.Add(p);
            }
            foreach (Ponto p in pontos)
            {
                xMedio += p.x;
                yMedio += p.y;
            }
            xMedio = xMedio / qtd;
            yMedio = yMedio / qtd;
            yMedio = Math.Round(yMedio);
            xMedio = Math.Round(xMedio);
            for (int j = 0; j < pontos.Count; j++)
            {
                double a = Math.Pow(pontos[(j + 1) % pontos.Count].x - pontos[j].x, 2);
                double b = Math.Pow(pontos[(j + 1) % pontos.Count].y - pontos[j].y, 2);
                distMedia += Math.Sqrt(a + b);
            }
            Console.WriteLine("A Distância média é: {0}", distMedia);
            Console.WriteLine("Ponto Médio: {0},{1}", xMedio, yMedio);
        }
    }
}
