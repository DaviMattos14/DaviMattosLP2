using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenhoProvaAmanhã1
{
    class Conta
    {
        public int NumeroDaConta { get; set; }
        public string Titular { get; set; } 
        public double Saldo { get; set; }

        public bool Saque (double valor)
        {
            if (valor < Saldo)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
        public void Deposito (double valorDeposito)
        {
                Saldo += valorDeposito;
        }
    }
}
