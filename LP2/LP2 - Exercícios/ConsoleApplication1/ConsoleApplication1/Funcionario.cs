using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Funcionario
    {
        public string CPF { get; set;}
        public string Nome { get; set;}
        public DateTime DataDeNascimento { get; set; }
        public double Salario { get; set;}

        public Funcionario(string _cpf,  string _nome)
        {
            CPF = _cpf;
            Nome = _nome;
        }


    }
}
