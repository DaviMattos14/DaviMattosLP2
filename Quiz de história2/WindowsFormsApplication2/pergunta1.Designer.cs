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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pergunta1));
            this.questão = new System.Windows.Forms.Label();
            this.pergunta = new System.Windows.Forms.Label();
            this.Resposta1 = new System.Windows.Forms.Label();
            this.alt1 = new System.Windows.Forms.RadioButton();
            this.alt2 = new System.Windows.Forms.RadioButton();
            this.verificar = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.alt3 = new System.Windows.Forms.RadioButton();
            this.alt4 = new System.Windows.Forms.RadioButton();
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
            this.questão.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pergunta
            // 
            this.pergunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pergunta.Location = new System.Drawing.Point(200, 18);
            this.pergunta.Name = "pergunta";
            this.pergunta.Size = new System.Drawing.Size(368, 80);
            this.pergunta.TabIndex = 1;
            this.pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pergunta.Click += new System.EventHandler(this.label2_Click);
            // 
            // Resposta1
            // 
            this.Resposta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resposta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resposta1.Location = new System.Drawing.Point(251, 272);
            this.Resposta1.Name = "Resposta1";
            this.Resposta1.Size = new System.Drawing.Size(297, 80);
            this.Resposta1.TabIndex = 2;
            this.Resposta1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Resposta1.Click += new System.EventHandler(this.label3_Click);
            // 
            // alt1
            // 
            this.alt1.AutoSize = true;
            this.alt1.Location = new System.Drawing.Point(236, 152);
            this.alt1.Name = "alt1";
            this.alt1.Size = new System.Drawing.Size(14, 13);
            this.alt1.TabIndex = 3;
            this.alt1.TabStop = true;
            this.alt1.UseVisualStyleBackColor = true;
            this.alt1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // alt2
            // 
            this.alt2.AutoSize = true;
            this.alt2.Location = new System.Drawing.Point(236, 201);
            this.alt2.Name = "alt2";
            this.alt2.Size = new System.Drawing.Size(14, 13);
            this.alt2.TabIndex = 4;
            this.alt2.TabStop = true;
            this.alt2.UseVisualStyleBackColor = true;
            this.alt2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // verificar
            // 
            this.verificar.Location = new System.Drawing.Point(12, 312);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(115, 55);
            this.verificar.TabIndex = 7;
            this.verificar.Text = "Verificar";
            this.verificar.UseVisualStyleBackColor = true;
            this.verificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(637, 312);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(111, 55);
            this.next.TabIndex = 8;
            this.next.Text = "Next >>";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // alt3
            // 
            this.alt3.AutoSize = true;
            this.alt3.Location = new System.Drawing.Point(429, 152);
            this.alt3.Name = "alt3";
            this.alt3.Size = new System.Drawing.Size(14, 13);
            this.alt3.TabIndex = 9;
            this.alt3.TabStop = true;
            this.alt3.UseVisualStyleBackColor = true;
            // 
            // alt4
            // 
            this.alt4.AutoSize = true;
            this.alt4.Location = new System.Drawing.Point(429, 201);
            this.alt4.Name = "alt4";
            this.alt4.Size = new System.Drawing.Size(14, 13);
            this.alt4.TabIndex = 10;
            this.alt4.TabStop = true;
            this.alt4.UseVisualStyleBackColor = true;
            // 
            // pergunta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 379);
            this.Controls.Add(this.alt4);
            this.Controls.Add(this.alt3);
            this.Controls.Add(this.next);
            this.Controls.Add(this.verificar);
            this.Controls.Add(this.alt2);
            this.Controls.Add(this.alt1);
            this.Controls.Add(this.Resposta1);
            this.Controls.Add(this.pergunta);
            this.Controls.Add(this.questão);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pergunta1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nível 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questão;
        private System.Windows.Forms.Label pergunta;
        private System.Windows.Forms.Label Resposta1;
        private System.Windows.Forms.RadioButton alt1;
        private System.Windows.Forms.RadioButton alt2;
        private System.Windows.Forms.Button verificar;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.RadioButton alt3;
        private System.Windows.Forms.RadioButton alt4;
    }
}