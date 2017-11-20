using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TrabalhoLP4
{
    class Program
    {
        public enum ItemMenu { Jogar = 1, Informações, Sair}
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Sem Ar";
            
            Dictionary<Jogador, TimeSpan> tempos = new Dictionary<Jogador, TimeSpan>();
            ItemMenu jogar = ItemMenu.Jogar;
            ItemMenu info = ItemMenu.Informações;
            ItemMenu sair = ItemMenu.Sair;
            int op = 0;
            while (true)
            {
                Console.WriteLine("Bem-vindo ao jogo Sem Ar");
                Console.WriteLine("{0}-{1} {2}-{3} {4}-{5}", (int)jogar, jogar, (int)info, info, (int)sair, sair);
                try
                {
                    op = int.Parse(Console.ReadLine());
                    if (op < 1 || op > 3)
                        throw new Exception();
                }
                catch(Exception e )
                {
                    Console.WriteLine("Digite apenas um número de 1 a 3!");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (op == (int)info)
                {
                    Console.Clear();
                    Console.WriteLine("Sem Ar consiste em uma competição entre vários jogadores, para ver quem aguenta ficar mais" +
                        " tempo sem respirar.\nA competição é dividida em dois rounds e o vencedor será aquele que a soma dos tempos dos" +
                        " dois rounds for maior.\nPara jogar, é necessário fazer um rápido cadastro, com o nome e data de nascimento." +
                        "\nLembre-se de que caso haja duas ou mais pessoas com mesmo nome, diferencie-as pondo seus sobrenomes ou algum apelido." +
                        "\nOs jogadores mais velhos serão os primeiros a jogar.\nAperte qualquer tecla para voltar ao menu anterior.");
                    Console.ReadKey();
                    Console.Clear();
                }
                if (op == (int)jogar)
                {
                    Console.Clear();
                    Console.WriteLine("Quantos jogadores são?");
                    try
                    {
                        int n = int.Parse(Console.ReadLine());
                        Console.Clear();
                        for (int i = 0; i < n; i++)
                        {
                            Jogador j = new Jogador();
                            TimeSpan t = new TimeSpan();
                            Console.WriteLine("Digite o nome do {0}° jogador:", i + 1);
                            j.Nome = Console.ReadLine();
                            Console.WriteLine("Digite a data de nascimento do {0}° jogador (No formato DD/MM/AAAA)", i + 1);
                            j.DataNascimento = DateTime.Parse(Console.ReadLine());
                            tempos.Add(j, t);
                        }
                        Console.Clear();
                        for (int i = 0; i < 2; i++)
                        {
                            foreach (Jogador j in tempos.Keys.OrderBy(j => j.DataNascimento))
                            {
                                Console.WriteLine("{0}° round.", i + 1);
                                Stopwatch sw = new Stopwatch();
                                Console.WriteLine("{0}, nascido em {1}, é a sua vez.\nPrenda sua respiração e aperte qualquer tecla para começar a contagem do" +
                                    " {2}° round.", j.Nome, j.DataNascimento.ToString("dd/MM/yyyy"), i + 1);
                                Console.ReadKey();
                                sw.Start();
                                Console.Clear();
                                Console.WriteLine("{0}° round.", i + 1);
                                Console.WriteLine("{0}, quando você não aguentar mais, aperte qualquer tecla para parar a contagem do {1}° round:", j.Nome, i + 1);
                                Console.ReadKey();
                                sw.Stop();
                                Console.Clear();
                                Console.WriteLine("{0}° round.", i + 1);
                                TimeSpan ts = sw.Elapsed;
                                tempos[j] += ts;
                                Console.WriteLine("Parabéns, {0}, você conseguiu ficar {1}m {2}s {3}ms sem respirar!", j.Nome, ts.Minutes, ts.Seconds, ts.Milliseconds);
                                Console.WriteLine("Aperte qualquer tecla para continuar.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        Console.WriteLine("Resultado:");
                        Jogador ganhador = new Jogador(); ;
                        TimeSpan maiorTempo = new TimeSpan();
                        foreach (KeyValuePair<Jogador, TimeSpan> par in tempos)
                        {
                            if (par.Value > maiorTempo)
                            {
                                ganhador = par.Key;
                                maiorTempo = par.Value;
                            }
                            Console.WriteLine("{0}: {1}m {2}s {3}ms", par.Key.Nome, par.Value.Minutes, par.Value.Seconds, par.Value.Milliseconds);
                        }

                        Console.WriteLine("Parabéns, {0}, você venceu essa disputa, com {1}s {2}m {3}ms acumulados nos dois rounds!",
                            ganhador.Nome, tempos[ganhador].Minutes, tempos[ganhador].Seconds, tempos[ganhador].Milliseconds);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Algo de errado aconteceu!\nProvavelmente você digitou uma data inválida. ");
                    }
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial.");
                    Console.ReadKey();
                    Console.Clear();

                }
                if (op == (int)sair)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
