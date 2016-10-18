using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //cmd.ExecuteScalar(); --> Retorna um Objeto número. Ex: Select SUM(p.Preco) FROM Produto
            //                         double precoTotal = Convert.ToDouble(cmd.ExecuteScalar());
            // cmd.ExecuteNonQuery(); --> Retorna quantos registros (int) foram alterados.
            //                            Usando com UPDATTE, DELETE e INSERT
            //                            int linhas = cmd.ExecuteNonQuery();

            //CONFIGURAÇÃO 
            string connStr = "Server=localhost;Database=lp2;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(connStr);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM CARRO c WHERE c.IdCidade = 1;";

            //Execução
            cmd.Connection.Open(); // conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            
            List<Carro> carros = new List<Carro>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Carro c = new Carro();
                    c.Id = reader.GetInt32(0);
                    c.Placa = reader.GetString(1);
                    c.IdCidade = reader.GetInt32(2);
                    c.PrecoDeVenda = reader.GetDouble(3);

                    carros.Add(c);
                }
            }
            else
            {
                Console.WriteLine("Sem Registros.");
            }

                //reader.Read();
            Console.WriteLine("Foram encontrados {0} registros de carros. \n", carros.Count);
                string nome = reader.GetString(0);
                Console.WriteLine("Nome: {0}", nome);

                cmd.Connection.Close(); // Só fechar a Connection quando terminar toda a leitura do reader

                foreach (Carro c in carros)
                {
                    Console.WriteLine("ID: {0}", c.Id);
                    Console.WriteLine("Placa: {0}", c.Placa);
                    Console.WriteLine("Cidade: {0}", c.IdCidade);
                    Console.WriteLine("Preço de Revenda: R${0:0.00}", c.PrecoDeVenda);
                    Console.WriteLine();
                }
        }
    }
}
