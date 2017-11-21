using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenhoProvaAmanhã1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            List<Conta> contas = new List<Conta>();
            Console.Write("Contas a cadastrar: ");
            int qtdContas = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdContas; i++)
            {
                Console.Write("Numero da Conta: ");
                conta.NumeroDaConta = int.Parse(Console.ReadLine());
                Console.Write("Nome do titular: ");
                conta.Titular = Console.ReadLine();
                Console.Write("Saldo: ");
                conta.Saldo = double.Parse(Console.ReadLine());
                contas.Add(conta);
            }

            Console.Write("Nº da conta para consulta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            int j = 0;
            bool aux = true;
            while(aux)
            {
                if (numeroConta == contas[j].NumeroDaConta)
                {
                    Console.Write("Valor de Deposito: ");
                    double deposito = double.Parse(Console.ReadLine());
                    conta.Deposito(deposito);

                    Console.Write("Valor de Saque: ");
                    double valorSaque = double.Parse(Console.ReadLine());

                    bool saque = conta.Saque(valorSaque);
                    if (saque == true) Console.WriteLine("Saque Realizado com Sucesso");
                    else Console.WriteLine("Saque Falhou");

                    Console.WriteLine("Conta: {0} Titular: {1} Saldo: {2,8:c}", contas[j].NumeroDaConta, contas[j].Titular, contas[j].Saldo);
                    aux = false;
                }
                else //if (j > qtdContas)
                {
                    Console.WriteLine("Error");
                    aux = false;
                }
                j++;
            }

            






        }
    }
}
