using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int player = 9;
        public void Faz(Button b)
        {
            if (player % 2 == 0)
            {
                b.Text = "X";
                player--;
            }
            else
            {
                b.Text = "O";
                player--;
            }
        }

        public string Verificar()
        {
            if(b1.Text == b2.Text && b1.Text == b3.Text)
            {
                return b1.Text.ToString();
            }
            else  if (b4.Text == b5.Text && b4.Text == b6.Text)
            {
                return b4.Text.ToString();
            }
            else  if (b7.Text == b8.Text && b7.Text == b9.Text)
            {
                return b7.Text.ToString();
            }
            else  if (b1.Text == b4.Text && b1.Text == b7.Text)
            {
                return b7.Text.ToString();
            }
            else if (b2.Text == b5.Text && b2.Text == b8.Text)
            {
                return b2.Text.ToString();
            }
            else if (b3.Text == b6.Text && b3.Text == b9.Text)
            {
                return b3.Text.ToString();
            }
            else if (b1.Text == b5.Text && b1.Text == b9.Text)
            {
                return b1.Text.ToString();
            }
            else if (b3.Text == b5.Text && b3.Text == b7.Text)
            {
                return b3.Text.ToString();
            }
            if (player == 0)
                return "Velha";
            return " ";
        }
        string vencedor;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Faz(b1);
          vencedor = Verificar();

        }

        private void b2_Click(object sender, EventArgs e)
        {
            Faz(b2);
            vencedor = Verificar();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Faz(b3);
            vencedor = Verificar();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Faz(b4);
            vencedor = Verificar();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Faz(b5);
            vencedor = Verificar();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Faz(b6);
            vencedor = Verificar();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Faz(b7);
            vencedor = Verificar();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Faz(b8);
            vencedor = Verificar();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Faz(b9);
            vencedor = Verificar();
        }

        MessageBox.
    }
}
