namespace WindowsFormsApplication2
{
    partial class pergunta1
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
            this.questão = new System.Windows.Forms.Label();
            this.pergunta = new System.Windows.Forms.Label();
            this.Resposta1 = new System.Windows.Forms.Label();
            this.alt1 = new System.Windows.Forms.RadioButton();
            this.alt2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.verificar = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questão
            // 
            this.questão.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.questão.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questão.Location = new System.Drawing.Point(12, 9);
            this.questão.Name = "questão";
            this.questão.Size = new System.Drawing.Size(95, 37);
            this.questão.TabIndex = 0;
            this.questão.Text = "Questão 1.";
            this.questão.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pergunta
            // 
            this.pergunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pergunta.Location = new System.Drawing.Point(175, 51);
            this.pergunta.Name = "pergunta";
            this.pergunta.Size = new System.Drawing.Size(244, 44);
            this.pergunta.TabIndex = 1;
            this.pergunta.Text = "Quanto é 2+2?";
            this.pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pergunta.Click += new System.EventHandler(this.label2_Click);
            // 
            // Resposta1
            // 
            this.Resposta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta1.Location = new System.Drawing.Point(189, 193);
            this.Resposta1.Name = "Resposta1";
            this.Resposta1.Size = new System.Drawing.Size(208, 51);
            this.Resposta1.TabIndex = 2;
            this.Resposta1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Resposta1.Click += new System.EventHandler(this.label3_Click);
            // 
            // alt1
            // 
            this.alt1.AutoSize = true;
            this.alt1.Location = new System.Drawing.Point(276, 134);
            this.alt1.Name = "alt1";
            this.alt1.Size = new System.Drawing.Size(31, 17);
            this.alt1.TabIndex = 3;
            this.alt1.TabStop = true;
            this.alt1.Text = "2";
            this.alt1.UseVisualStyleBackColor = true;
            this.alt1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // alt2
            // 
            this.alt2.AutoSize = true;
            this.alt2.Location = new System.Drawing.Point(276, 157);
            this.alt2.Name = "alt2";
            this.alt2.Size = new System.Drawing.Size(31, 17);
            this.alt2.TabIndex = 4;
            this.alt2.TabStop = true;
            this.alt2.Text = "4";
            this.alt2.UseVisualStyleBackColor = true;
            this.alt2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "(A)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "(B)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // verificar
            // 
            this.verificar.Location = new System.Drawing.Point(32, 259);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(75, 23);
            this.verificar.TabIndex = 7;
            this.verificar.Text = "Verificar";
            this.verificar.UseVisualStyleBackColor = true;
            this.verificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(526, 251);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 39);
            this.next.TabIndex = 8;
            this.next.Text = "Next >>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 302);
            this.Controls.Add(this.next);
            this.Controls.Add(this.verificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alt2);
            this.Controls.Add(this.alt1);
            this.Controls.Add(this.Resposta1);
            this.Controls.Add(this.pergunta);
            this.Controls.Add(this.questão);
            this.Name = "pergunta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1º Pergunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questão;
        private System.Windows.Forms.Label pergunta;
        private System.Windows.Forms.Label Resposta1;
        private System.Windows.Forms.RadioButton alt1;
        private System.Windows.Forms.RadioButton alt2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.Button next;
    }
}