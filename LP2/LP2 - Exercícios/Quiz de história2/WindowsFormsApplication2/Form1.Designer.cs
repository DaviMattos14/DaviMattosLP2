namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.niveis = new System.Windows.Forms.ComboBox();
            this.sel_nivel = new System.Windows.Forms.Label();
            this.pont = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(151, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(186, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // niveis
            // 
            this.niveis.FormattingEnabled = true;
            this.niveis.Location = new System.Drawing.Point(186, 147);
            this.niveis.Name = "niveis";
            this.niveis.Size = new System.Drawing.Size(123, 21);
            this.niveis.TabIndex = 3;
            this.niveis.SelectedIndexChanged += new System.EventHandler(this.niveis_SelectedIndexChanged);
            // 
            // sel_nivel
            // 
            this.sel_nivel.AutoSize = true;
            this.sel_nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_nivel.Location = new System.Drawing.Point(173, 110);
            this.sel_nivel.Name = "sel_nivel";
            this.sel_nivel.Size = new System.Drawing.Size(151, 20);
            this.sel_nivel.TabIndex = 4;
            this.sel_nivel.Text = "Selecione o Nível:";
            // 
            // pont
            // 
            this.pont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pont.Location = new System.Drawing.Point(536, 110);
            this.pont.Name = "pont";
            this.pont.Size = new System.Drawing.Size(49, 23);
            this.pont.TabIndex = 5;
            this.pont.Click += new System.EventHandler(this.pont_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pontuação Final:";
            // 
            // zerar
            // 
            this.zerar.Location = new System.Drawing.Point(526, 136);
            this.zerar.Name = "zerar";
            this.zerar.Size = new System.Drawing.Size(75, 23);
            this.zerar.TabIndex = 7;
            this.zerar.Text = "Restart";
            this.zerar.UseVisualStyleBackColor = true;
            this.zerar.Click += new System.EventHandler(this.zerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(757, 373);
            this.Controls.Add(this.zerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pont);
            this.Controls.Add(this.sel_nivel);
            this.Controls.Add(this.niveis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz - África Subsaariana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox niveis;
        private System.Windows.Forms.Label sel_nivel;
        private System.Windows.Forms.Label pont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button zerar;
    }
}

