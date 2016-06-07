using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangulo
    {
        private double posX;
        private double posY;
        private int id;
        private double cor;
        private double lado12;

        private double _lado1;
        public double Lado1
        {
            get { return _lado1; }
            set
            {
                if (value > 0)
                    _lado1 = value;
            }
        }
        private double _lado2;
        public double Lado2
        {
            get { return _lado2; }
            set
            {
                if (value > 0)
                    _lado2 = value;
            }
        }
        private double _lado3;
        public double Lado3
        {
            get { return _lado3; }
            set
            {
                if (value > 0)
                    _lado3 = value;
            }
        }
        public double Cor 
        {
            get { return this.cor; }
            set
            {
                if (value >= 0 && value <= Math.Pow(2, 24))
                    value = this.cor;
            }
        }
        public Triangulo(double lado1, double lado2, double lado3)
        {
            
            lado12 = Lado1 + Lado2;
            if (lado12 > Lado3) 
            {
                lado1 = _lado1;
                lado2 = _lado2;
                lado3 = _lado3;
            }
        }
    }
}
