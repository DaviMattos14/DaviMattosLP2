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

            new Pessoa();


        }
    }
    class Pessoa
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string cpf { get; set; }
        public int telCelular { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Pessoa() { }   
        public Pessoa(string nome1, string sobrenome1)
        {
            this.nome = nome1;
            this.sobrenome = sobrenome1;
        }
        public Pessoa(string cpf1)
        {
            this.cpf = cpf1;
        }
        public Pessoa(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
    }
}
