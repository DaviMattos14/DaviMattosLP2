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
            string nome = Console.ReadLine();
            string sobrenome = Console.ReadLine();
            double salario_Mensal = double.Parse(Console.ReadLine());
            Empregado e = new Empregado(salario_Mensal, nome, sobrenome);
            Console.Clear();
            Console.WriteLine("Nome: {0} {1}", nome, sobrenome);
            Console.WriteLine("Salrio Mensal: {0}", salario_Mensal);
            Console.WriteLine("Salario Anual: {0}", e.SalarioAnual);
            Console.WriteLine("Aumento: {0}", e.Aumento10);
            Console.WriteLine("Salario Final: {0}", e.SalarioAnual + e.Aumento10);

        }
    }

    class Empregado
    {
        public double SalarioMensal { get; set; }
        public double SalarioAnual = 0;
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double Aumento10 = 0;

        public Empregado(double _salarioMensal, string _nome, string _sobrenome)
        {
            if (_salarioMensal < 0)
            {
                SalarioMensal = 0;
                SalarioAnual = 0;
            }
            else
                SalarioAnual = _salarioMensal * 12;
            _nome = Nome;
            _sobrenome = Sobrenome;
            Aumento10 = SalarioAnual * 0.1;


        }
    }
}
