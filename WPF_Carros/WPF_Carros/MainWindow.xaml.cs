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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Carros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Modelo()
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
                CommandText = "SELECT Modelo FROM CARROS"
            };

            cmd.Connection.Open();

            MySqlDataReader result = cmd.ExecuteReader();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    lboxModelo.Items.Add(result.GetString(0));
                }
            }

            cmd.Connection.Close();
        }

        private void Placa()
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
                CommandText = "SELECT Placa FROM CARROS"
            };

            cmd.Connection.Open();

            MySqlDataReader Placa = cmd.ExecuteReader();

            if (Placa.HasRows)
            {
                while (Placa.Read())
                {
                    lboxPlaca.Items.Add(Placa.GetString(0));
                }
            }

            cmd.Connection.Close();
        }
        private void Cadastrar()
        {
            MySqlCommand cmd = new MySqlCommand()
            {
                Connection = new MySqlConnection("Server=localhost;Database=test;Uid=root;Pwd="),
                CommandText = "INSERT INTO Carros(Modelo, Ano, Placa, Dono) VALUES (@modelo, @ano, @placa, @dono)"
            };

            cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
            cmd.Parameters.AddWithValue("@ano", txtAno.Text);
            cmd.Parameters.AddWithValue("@placa", txtPlaca.Text);
            cmd.Parameters.AddWithValue("@dono", txtDono.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        private void Limpar()
        {
            txtModelo.Clear();
            txtAno.Clear();
            txtDono.Clear();
            txtPlaca.Clear();
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar();
            Limpar();
        }

        private void btAtualizar_Click(object sender, RoutedEventArgs e)
        {
            lboxModelo.Items.Clear();
            lboxPlaca.Items.Clear();
            Modelo();
            Placa();
        }
    }
}
