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
            this.BackColor = System.Drawing.Color.LightSalmon;
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
                    alt3.Text = "1";
                    alt4.Text = "3";
                    Resposta1.Text = "";
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
                    Resposta1.Text = "";
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
                    Resposta1.Text = "";
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
                        Resposta1.Text = "Resposta Certa!";
                        pontuacao += 10;
                    }
                        
                    if (alt1.Checked == true)
                        Resposta1.Text = "Resposta Errada!";
                    if (alt3.Checked == true)
                        Resposta1.Text = "Resposta Errada!";
                    if (alt4.Checked == true)
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
                    if (questão.Text == "Questão 3.") 
                    {
                        if (Resposta1.Text != "")
                        {
                            next.Text = "Finalizar";
                            this.Close(); 
                        }
                            
                    }
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
                    if (alt3.Checked == true)
                        Resposta1.Text = "Resposta Errada!";
                    if (alt4.Checked == true)
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
                    if (alt3.Checked == true)
                        Resposta1.Text = "Resposta Errada!";
                    if (alt4.Checked == true)
                        Resposta1.Text = "Resposta Errada!";
                    verificar.Enabled = false;
                    return true;
                }
        
                
                
    }
}

    
           
        


