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
        double num1;
        string ultimaOperacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtEntrada.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtEntrada.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtEntrada.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtEntrada.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtEntrada.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtEntrada.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtEntrada.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtEntrada.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtEntrada.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtEntrada.Text += "0";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            num1 += double.Parse(txtEntrada.Text);
            txtEntrada.Clear();
            ultimaOperacao = "soma";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 += double.Parse(txtEntrada.Text);
            txtEntrada.Clear();
            ultimaOperacao = "multiplicacao";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            num1 += double.Parse(txtEntrada.Text);
            txtEntrada.Clear();
            ultimaOperacao = "divisao";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            num1 += double.Parse(txtEntrada.Text);
            txtEntrada.Clear();
            ultimaOperacao = "subtracao";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            num1 = 0;
            txtEntrada.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == "soma")
                num1 = num1 + double.Parse(txtEntrada.Text);
            if (ultimaOperacao == "multiplicacao")
                num1 = num1 * double.Parse(txtEntrada.Text);
            if (ultimaOperacao == "subtracao")
                num1 = num1 - double.Parse(txtEntrada.Text);
            else if (ultimaOperacao == "divisao")
                num1 = num1 / double.Parse(txtEntrada.Text);
            txtEntrada.Clear();
            txtEntrada.Text = num1.ToString();
            num1 = 0;
        }
      
    }
}
