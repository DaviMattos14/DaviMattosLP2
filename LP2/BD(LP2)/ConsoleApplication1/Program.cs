using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string connString = "Server=localhost;Database=lp2;Uid=root;Pwd=";
        //    MySqlConnection conn = new MySqlConnection(connString);

        //    MySqlCommand cmd = new MySqlCommand();
        //    cmd.Connection = conn;
        //    cmd.CommandText = "SELECT COUNT(1) FROM Pessoa;";

        //    cmd.Connection.Open(); // conn.Open();
        //    //int result = (int)cmd.ExecuteScalar();
        //    int result = Convert.ToInt32(cmd.ExecuteScalar());
        //    conn.Close();
        //    Console.WriteLine(result);

            // Steup

            Console.Write("Digite o ID: ");
            int id = int.Parse(Console.ReadLine());

            string connStr = ("Server=localhost;Database=aula;Uid=root;Pwd=");
            MySqlConnection conn = new MySqlConnection(connStr);

            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "SELECT AVERAGE(1) FROM PRODUTO;";

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=localhost;Database=aula;Uid=root;Pwd="),
                CommandText = String.Format("SELECT p.nome, p.preço FROM PRODUTO p WHERE p.ID = {0};", id)
            };
        // Consulta
                cmd.Connection.Open();
                MySqlDataReader r = cmd.ExecuteReader();
                r.Read();
                string nome = r.GetString(0); // (x) - x é a ordem que está na query
                double preco = r.GetDouble(1);
                cmd.Connection.Close();

                Console.WriteLine("{0} = R$ {1}", nome, preco);
        }
    }
}
