namespace JuroSimples
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_capital = new System.Windows.Forms.TextBox();
            this.tbx_tempo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_taxa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_juros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital :";
            // 
            // tbx_capital
            // 
            this.tbx_capital.Location = new System.Drawing.Point(251, 61);
            this.tbx_capital.Name = "tbx_capital";
            this.tbx_capital.Size = new System.Drawing.Size(102, 20);
            this.tbx_capital.TabIndex = 1;
            // 
            // tbx_tempo
            // 
            this.tbx_tempo.Location = new System.Drawing.Point(251, 113);
            this.tbx_tempo.Name = "tbx_tempo";
            this.tbx_tempo.Size = new System.Drawing.Size(102, 20);
            this.tbx_tempo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Meses : ";
            // 
            // tbx_taxa
            // 
            this.tbx_taxa.Location = new System.Drawing.Point(251, 87);
            this.tbx_taxa.Name = "tbx_taxa";
            this.tbx_taxa.Size = new System.Drawing.Size(102, 20);
            this.tbx_taxa.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Taxa :";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(260, 173);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lbl_juros
            // 
            this.lbl_juros.AutoSize = true;
            this.lbl_juros.Location = new System.Drawing.Point(249, 146);
            this.lbl_juros.Name = "lbl_juros";
            this.lbl_juros.Size = new System.Drawing.Size(80, 13);
            this.lbl_juros.TabIndex = 7;
            this.lbl_juros.Text = "Valor do juros : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_juros);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.tbx_taxa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_tempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_capital);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_capital;
        private System.Windows.Forms.TextBox tbx_tempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_taxa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_juros;
    }
}

