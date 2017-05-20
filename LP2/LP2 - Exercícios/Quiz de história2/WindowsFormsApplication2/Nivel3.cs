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
    public partial class Nivel3 : Form
    {
        public int pontuacao = 0;
        public Nivel3()
        {
            InitializeComponent();
            Pergunta1();
            BackColor = System.Drawing.Color.PowderBlue;
            
        }

        private void pergunta_Click(object sender, EventArgs e)
        {

        }
        private void Pergunta1()
        {
            questão.Text = "Questão 1.";
            pergunta.Text = "Quanto é 2+2?";
            alt1.Text = "2";
            alt2.Text = "4";
            alt3.Text = "1";
            alt4.Text = "3";
            resposta.Text = "";
            verificar.Enabled = true;
            next.Enabled = false;
            alt1.Checked = false;
            alt2.Checked = false;
            alt3.Checked = false;
            alt4.Checked = false;
        }
        private void Pergunta2()
        {
            questão.Text = "Questão 2.";
            pergunta.Text = "Qual é a cor do sol?";
            alt1.Text = "Amarelo";
            alt2.Text = "Laranja";
            alt3.Text = "Vermelho";
            alt4.Text = "Preto";
            resposta.Text = "";
            verificar.Enabled = true;
            next.Enabled = false;
            alt1.Checked = false;
            alt2.Checked = false;
            alt3.Checked = false;
            alt4.Checked = false;
        }
        private void Pergunta3()
        {
            questão.Text = "Questão 3.";
            pergunta.Text = "Qual é a cor do céu?";
            alt1.Text = "Preto";
            alt2.Text = "Azul";
            alt3.Text = "Cinza";
            alt4.Text = "Amarelo";
            resposta.Text = "";
            verificar.Enabled = true;
            next.Enabled = false;
            alt1.Checked = false;
            alt2.Checked = false;
            alt3.Checked = false;
            alt4.Checked = false;
        }

        private Boolean Verificar(bool valor)
        {
            if (alt2.Checked == true)
            {
                resposta.Text = "Resposta Certa!";
                pontuacao += 10;
            }

            if (alt1.Checked == true)
                resposta.Text = "Resposta Errada!";
            if (alt3.Checked == true)
                resposta.Text = "Resposta Errada!";
            if (alt4.Checked == true)
                resposta.Text = "Resposta Errada!";
            verificar.Enabled = false;
            return true;
        }

        private Boolean Verificar2(bool valor)
        {
            if (alt1.Checked == true)
            {
                resposta.Text = "Resposta Certa!";
                pontuacao += 10;

            }
            if (alt2.Checked == true)
                resposta.Text = "Resposta Errada!";
            verificar.Enabled = false;
            if (alt3.Checked == true)
                resposta.Text = "Resposta Errada!";
            if (alt4.Checked == true)
                resposta.Text = "Resposta Errada!";
            return true;
        }
        private Boolean Verificar3(bool valor)
        {
            if (alt1.Checked == true)
                resposta.Text = "Resposta Errada!";
            if (alt2.Checked == true)
            {
                resposta.Text = "Resposta Certa!";
                pontuacao += 10;
            }
            if (alt3.Checked == true)
                resposta.Text = "Resposta Errada!";
            if (alt4.Checked == true)
                resposta.Text = "Resposta Errada!";
            verificar.Enabled = false;
            return true;
        }

        private void verificar_Click_1(object sender, EventArgs e)
        {
            if (questão.Text == "Questão 1.")
            {
                if (Verificar(true))
                {
                    next.Enabled = true;
                }
            }

            if (questão.Text == "Questão 2.")
            {
                if (Verificar2(true))
                {
                    next.Enabled = true;
                }
            }
            if (questão.Text == "Questão 3.")
            {
                if (Verificar3(true))
                {
                    next.Enabled = true;
                }
            }
        }

        private void next_Click_1(object sender, EventArgs e)
        {
            if (questão.Text == "Questão 1.")
            {
                if (resposta.Text != "")
                    Pergunta2();
            }
            if (questão.Text == "Questão 2.")
            {
                if (resposta.Text != "")
                    Pergunta3();
            }
            if (questão.Text == "Questão 3.")
            {
                if (resposta.Text != "")
                {
                    next.Text = "FIm";
                    this.Close();
                }
            }
        }
    }
}
