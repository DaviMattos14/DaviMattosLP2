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
    public partial class FrmCadastrar : Form
    {
        Jogo j = new Jogo();
        Gerenciador g = new Gerenciador();
        int count = 0;
        public FrmCadastrar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            count++;
            j.Nome = txtNome.Text;
            j.Genero = txtGenero.Text;
            j.Codigo = count;
            txtNome.Clear();
            txtGenero.Clear();
            g.AdicionarJogo(j);
            lblQntd.Text = "Itens Cadastrados: " + count.ToString(); 
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(g.GerarDadosLista());
        }

    }
}
