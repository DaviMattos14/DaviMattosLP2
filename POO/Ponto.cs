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
            int qtd = int.Parse(Console.ReadLine());
            List<Ponto> pontos = new List<Ponto>();
            double xMedio = 0;
            double yMedio = 0;
            for (int i = 0; i < qtd; i++)
            {
                Ponto p = new Ponto();
                Console.Write("X: ");
                p.x = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                p.y = int.Parse(Console.ReadLine());
                pontos.Add(p);
            }
            for (int j = 0; j < qtd; j++)
            {
                xMedio += pontos[j].x;
            }
            xMedio = xMedio / qtd;
            for (int k = 0; k < qtd; k ++)
            {
                yMedio += pontos[k].y;
            }
            yMedio = yMedio / qtd;
            yMedio = Math.Round(yMedio);
            xMedio = Math.Round(xMedio);
            Console.WriteLine("Ponto Médio: {0},{1}", xMedio, yMedio);
        }
    }
    
}
