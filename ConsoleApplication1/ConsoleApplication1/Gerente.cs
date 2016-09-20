using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Gerente : Funcionario    
    {
        public double bonus { get; set; }
        public string Departamento { get; set; }

        public Gerente(string _departamento, string _nome, string _cpf):base(_nome, _cpf)
        {
            Departamento = _departamento; 
        }
    }
}
