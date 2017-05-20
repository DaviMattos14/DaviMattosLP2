using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1 = double.Parse(Console.ReadLine());
            double lado2 = double.Parse(Console.ReadLine());
            double teste = lado2 + lado1;
            double lado3 = double.Parse(Console.ReadLine());
            if (teste > lado3)
            {
                double p = lado3 + lado2 + lado1;
                Triângulo t = new Triângulo(lado1, lado2, lado3);
                t.Cor = double.Parse(Console.ReadLine());
                t.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("ID: {0}", t.Id);
                Console.WriteLine("Perímetro: {0}", p);
            }
            

        }
    }
    public class Triângulo
    {
        private double _lado1, _lado2, _lado3, _cor;
        private int _id;
        public int Id
        {
            get { return _id; }

            set
            {
                if (value >= 0)
                    _id = value;
            }
        }

        public double Lado1
        {
            get { return _lado1; }

            set
            {
                if (value >= 0)
                    _lado1 = value;
            }
        }

        public double Lado2
        {
            get { return _lado2; }

            set
            {
                if (value >= 0)
                    _lado2 = value;
            }
        }

        public double Lado3
        {
            get { return _lado3; }

            set
            {
                if (value >= 0)
                    _lado3 = value;
            }
        }

        public double Cor
        {
            get { return this._cor; }
            set
            {
                if (value >= 0 && value <= Math.Pow(2, 24))
                    value = this._cor;
            }
        }

        public Triângulo(double lado1, double lado2, double lado3)
        {
                lado1 = _lado1;
                lado2 = _lado2;
                lado3 = _lado3;
        }

    }
}
