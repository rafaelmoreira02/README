namespace geometria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_capital = new System.Windows.Forms.TextBox();
            this.tbx_taxa_juros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_tempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_montante = new System.Windows.Forms.Button();
            this.lbl_montante = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_juros = new System.Windows.Forms.Label();
            this.btn_juros = new System.Windows.Forms.Button();
            this.tbx_capital2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbx_montante = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(248, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calculando Juros Compostos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Capital : ";
            // 
            // tbx_capital
            // 
            this.tbx_capital.Location = new System.Drawing.Point(113, 212);
            this.tbx_capital.Name = "tbx_capital";
            this.tbx_capital.Size = new System.Drawing.Size(98, 20);
            this.tbx_capital.TabIndex = 7;
            // 
            // tbx_taxa_juros
            // 
            this.tbx_taxa_juros.Location = new System.Drawing.Point(113, 238);
            this.tbx_taxa_juros.Name = "tbx_taxa_juros";
            this.tbx_taxa_juros.Size = new System.Drawing.Size(98, 20);
            this.tbx_taxa_juros.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Taxa de Juros : ";
            // 
            // tbx_tempo
            // 
            this.tbx_tempo.Location = new System.Drawing.Point(113, 264);
            this.tbx_tempo.Name = "tbx_tempo";
            this.tbx_tempo.Size = new System.Drawing.Size(98, 20);
            this.tbx_tempo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Meses : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(85, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Calculo do Montante";
            // 
            // btn_montante
            // 
            this.btn_montante.Location = new System.Drawing.Point(123, 290);
            this.btn_montante.Name = "btn_montante";
            this.btn_montante.Size = new System.Drawing.Size(75, 23);
            this.btn_montante.TabIndex = 13;
            this.btn_montante.Text = "Calcular";
            this.btn_montante.UseVisualStyleBackColor = true;
            this.btn_montante.Click += new System.EventHandler(this.btn_montante_Click);
            // 
            // lbl_montante
            // 
            this.lbl_montante.AutoSize = true;
            this.lbl_montante.Location = new System.Drawing.Point(100, 336);
            this.lbl_montante.Name = "lbl_montante";
            this.lbl_montante.Size = new System.Drawing.Size(122, 13);
            this.lbl_montante.TabIndex = 14;
            this.lbl_montante.Text = "O valor do Montante é : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(528, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Calculo do Juros";
            // 
            // lbl_juros
            // 
            this.lbl_juros.AutoSize = true;
            this.lbl_juros.Location = new System.Drawing.Point(528, 314);
            this.lbl_juros.Name = "lbl_juros";
            this.lbl_juros.Size = new System.Drawing.Size(102, 13);
            this.lbl_juros.TabIndex = 23;
            this.lbl_juros.Text = "O valor do Juros é : ";
            // 
            // btn_juros
            // 
            this.btn_juros.Location = new System.Drawing.Point(552, 264);
            this.btn_juros.Name = "btn_juros";
            this.btn_juros.Size = new System.Drawing.Size(75, 23);
            this.btn_juros.TabIndex = 22;
            this.btn_juros.Text = "Calcular";
            this.btn_juros.UseVisualStyleBackColor = true;
            this.btn_juros.Click += new System.EventHandler(this.btn_juros_Click);
            // 
            // tbx_capital2
            // 
            this.tbx_capital2.Location = new System.Drawing.Point(543, 238);
            this.tbx_capital2.Name = "tbx_capital2";
            this.tbx_capital2.Size = new System.Drawing.Size(98, 20);
            this.tbx_capital2.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Capital : ";
            // 
            // tbx_montante
            // 
            this.tbx_montante.Location = new System.Drawing.Point(543, 209);
            this.tbx_montante.Name = "tbx_montante";
            this.tbx_montante.Size = new System.Drawing.Size(98, 20);
            this.tbx_montante.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Montante : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_montante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_juros);
            this.Controls.Add(this.btn_juros);
            this.Controls.Add(this.tbx_capital2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_montante);
            this.Controls.Add(this.btn_montante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_tempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_taxa_juros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_capital);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_capital;
        private System.Windows.Forms.TextBox tbx_taxa_juros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_tempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_montante;
        private System.Windows.Forms.Label lbl_montante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_juros;
        private System.Windows.Forms.Button btn_juros;
        private System.Windows.Forms.TextBox tbx_capital2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbx_montante;
        private System.Windows.Forms.Label label9;
    }
}

