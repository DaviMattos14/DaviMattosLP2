namespace WindowsFormsApplication2
{
    partial class nivel2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nivel2));
            this.questão = new System.Windows.Forms.Label();
            this.verificar = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.pergunta = new System.Windows.Forms.Label();
            this.resposta = new System.Windows.Forms.Label();
            this.alt1 = new System.Windows.Forms.RadioButton();
            this.alt2 = new System.Windows.Forms.RadioButton();
            this.alt3 = new System.Windows.Forms.RadioButton();
            this.alt4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // questão
            // 
            this.questão.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.questão.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questão.Location = new System.Drawing.Point(12, 9);
            this.questão.Name = "questão";
            this.questão.Size = new System.Drawing.Size(114, 36);
            this.questão.TabIndex = 0;
            this.questão.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questão.Click += new System.EventHandler(this.questão_Click);
            // 
            // verificar
            // 
            this.verificar.Location = new System.Drawing.Point(12, 306);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(118, 60);
            this.verificar.TabIndex = 1;
            this.verificar.Text = "Verificar";
            this.verificar.UseVisualStyleBackColor = true;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(621, 306);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(124, 60);
            this.next.TabIndex = 2;
            this.next.Text = "Next >>>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pergunta
            // 
            this.pergunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pergunta.Location = new System.Drawing.Point(190, 33);
            this.pergunta.Name = "pergunta";
            this.pergunta.Size = new System.Drawing.Size(367, 74);
            this.pergunta.TabIndex = 3;
            this.pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pergunta.Click += new System.EventHandler(this.pergunta_Click);
            // 
            // resposta
            // 
            this.resposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resposta.Location = new System.Drawing.Point(256, 276);
            this.resposta.Name = "resposta";
            this.resposta.Size = new System.Drawing.Size(259, 64);
            this.resposta.TabIndex = 4;
            this.resposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alt1
            // 
            this.alt1.AutoSize = true;
            this.alt1.Location = new System.Drawing.Point(190, 163);
            this.alt1.Name = "alt1";
            this.alt1.Size = new System.Drawing.Size(14, 13);
            this.alt1.TabIndex = 5;
            this.alt1.TabStop = true;
            this.alt1.UseVisualStyleBackColor = true;
            // 
            // alt2
            // 
            this.alt2.AutoSize = true;
            this.alt2.Location = new System.Drawing.Point(190, 204);
            this.alt2.Name = "alt2";
            this.alt2.Size = new System.Drawing.Size(14, 13);
            this.alt2.TabIndex = 6;
            this.alt2.TabStop = true;
            this.alt2.UseVisualStyleBackColor = true;
            // 
            // alt3
            // 
            this.alt3.AutoSize = true;
            this.alt3.Location = new System.Drawing.Point(388, 163);
            this.alt3.Name = "alt3";
            this.alt3.Size = new System.Drawing.Size(14, 13);
            this.alt3.TabIndex = 7;
            this.alt3.TabStop = true;
            this.alt3.UseVisualStyleBackColor = true;
            // 
            // alt4
            // 
            this.alt4.AutoSize = true;
            this.alt4.Location = new System.Drawing.Point(388, 204);
            this.alt4.Name = "alt4";
            this.alt4.Size = new System.Drawing.Size(14, 13);
            this.alt4.TabIndex = 8;
            this.alt4.TabStop = true;
            this.alt4.UseVisualStyleBackColor = true;
            // 
            // nivel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 378);
            this.Controls.Add(this.alt4);
            this.Controls.Add(this.alt3);
            this.Controls.Add(this.alt2);
            this.Controls.Add(this.alt1);
            this.Controls.Add(this.resposta);
            this.Controls.Add(this.pergunta);
            this.Controls.Add(this.next);
            this.Controls.Add(this.verificar);
            this.Controls.Add(this.questão);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nivel2";
            this.Text = "Nível 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questão;
        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label pergunta;
        private System.Windows.Forms.Label resposta;
        private System.Windows.Forms.RadioButton alt1;
        private System.Windows.Forms.RadioButton alt2;
        private System.Windows.Forms.RadioButton alt3;
        private System.Windows.Forms.RadioButton alt4;
    }
}