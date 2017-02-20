using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Terceirizado : Empregado
    {
        public int Dependentes { get; set; }
        public Terceirizado(double _vr, string _nome, string _cpf) : base(_vr, _nome, _cpf)
        { }
    }
}
