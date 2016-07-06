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
    public partial class pergunta1 : Form
    {
        public int pontuacao = 0;
        public pergunta1()
        {
            InitializeComponent();
            Pergunta1();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(questão.Text == "Questão 1.")
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

                private void Pergunta1()
                {
                    questão.Text = "Questão 1.";
                    pergunta.Text = "Quanto é 2+2?";
                    alt1.Text = "2";
                    alt2.Text = "4";
                    Resposta1.Text = "";
                    verificar.Enabled = true;
                    next.Enabled = false;
                    alt1.Checked = false;
                    alt2.Checked = false;
                }
                private void Pergunta2() 
                {
                    questão.Text = "Questão 2.";
                    pergunta.Text = "Qual é a cor do sol?";
                    alt1.Text = "Amarelo";
                    alt2.Text = "Laranja";
                    Resposta1.Text = "";
                    verificar.Enabled = true;
                    next.Enabled = false;
                    alt1.Checked = false;
                    alt2.Checked = false;
                }
                private void Pergunta3() 
                {
                    questão.Text = "Questão 3.";
                    pergunta.Text = "Qual é a cor do céu?";
                    alt1.Text = "Preto";
                    alt2.Text = "Azul";
                    Resposta1.Text = "";
                    verificar.Enabled = true;
                    next.Enabled = false;
                    alt1.Checked = false;
                    alt2.Checked = false;
                }

                private void FimDeJogo()
                {
                    questão.Text = "";
                    pergunta.Text = "Fim de Jogo!";
                    alt1.Text = "";
                    alt2.Text = "";
                    Resposta1.Text = "Pontuação = " + pontuacao;
                    next.Text = "Finalizar";
                    verificar.Enabled = false;
                    next.Enabled = true;
                    alt1.Checked = true;
                    alt2.Checked = true;
                }

                private Boolean Verificar(bool valor) 
                {
                    if (alt2.Checked == true)
                    {
                        Resposta1.Text = "Resposta Certa!";
                        pontuacao += 10;
                    }
                        
                    if (alt1.Checked == true)
                        Resposta1.Text = "Resposta Errada!";
                    verificar.Enabled = false;
                    return true;
                }

                private void next_Click(object sender, EventArgs e)
                {
                    if (questão.Text == "Questão 1.")
                    {
                        if (Resposta1.Text != "")
                            Pergunta2();
                    }
                    if (questão.Text == "Questão 2.")
                    {
                        if(Resposta1.Text != "")
                            Pergunta3();
                    }
                    if (questão.Text == "Questão 3.") {
                        if (Resposta1.Text != "")
                            FimDeJogo();
                    }
                    if (questão.Text == "") {
                        if (Resposta1.Text != "")
                        this.Close(); }
                }
                private Boolean Verificar2(bool valor)
                {
                    if (alt1.Checked == true)
                    {
                        Resposta1.Text = "Resposta Certa!";
                        pontuacao += 10;

                    }
                    if (alt2.Checked == true)
                        Resposta1.Text = "Resposta Errada!";
                    verificar.Enabled = false;
                    return true;
                }
                private Boolean Verificar3(bool valor)
                {
                    if (alt1.Checked == true)
                        Resposta1.Text = "Resposta Errada!";
                    if (alt2.Checked == true)
                    {
                        Resposta1.Text = "Resposta Certa!";
                        pontuacao += 10;
                    }
                    verificar.Enabled = false;
                    return true;
                }
                
                
    }
}

    
           
        


