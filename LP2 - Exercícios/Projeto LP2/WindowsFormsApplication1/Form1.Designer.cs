namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pergunta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resposta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.materia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tema = new System.Windows.Forms.TextBox();
            this.salvar = new System.Windows.Forms.Button();
            this.dificuldade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pergunta
            // 
            this.pergunta.Location = new System.Drawing.Point(46, 84);
            this.pergunta.Name = "pergunta";
            this.pergunta.Size = new System.Drawing.Size(297, 20);
            this.pergunta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pergunta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resposta:";
            // 
            // resposta
            // 
            this.resposta.Location = new System.Drawing.Point(46, 148);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(297, 20);
            this.resposta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Matéria:";
            // 
            // materia
            // 
            this.materia.Location = new System.Drawing.Point(46, 208);
            this.materia.Name = "materia";
            this.materia.Size = new System.Drawing.Size(297, 20);
            this.materia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assunto:";
            // 
            // tema
            // 
            this.tema.Location = new System.Drawing.Point(46, 268);
            this.tema.Name = "tema";
            this.tema.Size = new System.Drawing.Size(297, 20);
            this.tema.TabIndex = 6;
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(268, 331);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 8;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            // 
            // dificuldade
            // 
            this.dificuldade.FormattingEnabled = true;
            this.dificuldade.Location = new System.Drawing.Point(46, 331);
            this.dificuldade.Name = "dificuldade";
            this.dificuldade.Size = new System.Drawing.Size(101, 21);
            this.dificuldade.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grau de dificuldade:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 440);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dificuldade);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pergunta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pergunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox materia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tema;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.ComboBox dificuldade;
        private System.Windows.Forms.Label label5;
    }
}

