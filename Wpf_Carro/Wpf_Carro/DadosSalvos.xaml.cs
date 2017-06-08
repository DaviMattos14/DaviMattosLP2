using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf_Carro
{
    /// <summary>
    /// Lógica interna para DadosSalvos.xaml
    /// </summary>
    public partial class DadosSalvos : Window
    {
        public DadosSalvos()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private static List<Carro> DadoSalvo()
        {
            List<Carro> car = new List<Carro>();
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=test;Uid=root;Pwd=root"),
                CommandText = "SELECT * FROM Carros"
            };

            cmd.Connection.Open();
            MySqlDataReader result = cmd.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Carro c = new Carro();
                    c.Id = result.GetInt32(0);
                    c.Ano = result.GetInt32(1);
                    c.Dono = result.GetString(2);
                    c.Modelo = result.GetString(3);
                    c.Placa = result.GetString(4);
                    car.Add(c);
                }
            }

            cmd.Connection.Close();

            return car;
        }

        private void btnCarregar_Click(object sender, RoutedEventArgs e)
        {
            List<Carro> car = DadoSalvo();
            if (car.Count == 0)
                MessageBox.Show("Não há registros salvos!");
            else
            {
                dataTabela.ItemsSource = car;
                dataTabela.CanUserAddRows = false;
            }
                

        }
    }
}
