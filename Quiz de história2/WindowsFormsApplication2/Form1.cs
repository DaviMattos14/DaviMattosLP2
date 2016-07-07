using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public int pontfinal = 0;
        
        public Form1()
        {
            InitializeComponent();
            niveis.Items.Add("Nível 1");
            niveis.Items.Add("Nível 2");
            niveis.Items.Add("Nível 3");
            pont.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            pergunta1 p1 = new pergunta1();
            nivel2 n2 = new nivel2();
            Nivel3 n3 = new Nivel3();
            if (niveis.Text == "Nível 1" || niveis.Text == "")
                 p1.ShowDialog();
            if (niveis.Text == "Nível 2")
                n2.ShowDialog();
            if (niveis.Text == "Nível 3")
                n3.ShowDialog();
            

            pontfinal += p1.pontuacao;
            pontfinal += n2.pontuacao;
            pontfinal += n3.pontuacao;
            pont.Text = pontfinal.ToString();
        }

        private void niveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void pont_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zerar_Click(object sender, EventArgs e)
        {
            pontfinal = 0;
            pont.Text = pontfinal.ToString();
        }
    }
}
