namespace calc_numbers
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
            this.tbx_n1 = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.cbx_operador = new System.Windows.Forms.ComboBox();
            this.tbx_n2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro número : ";
            // 
            // tbx_n1
            // 
            this.tbx_n1.Location = new System.Drawing.Point(305, 87);
            this.tbx_n1.Name = "tbx_n1";
            this.tbx_n1.Size = new System.Drawing.Size(100, 20);
            this.tbx_n1.TabIndex = 1;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(317, 166);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // cbx_operador
            // 
            this.cbx_operador.FormattingEnabled = true;
            this.cbx_operador.Items.AddRange(new object[] {
            "Somar",
            "Multiplicar"});
            this.cbx_operador.Location = new System.Drawing.Point(295, 139);
            this.cbx_operador.Name = "cbx_operador";
            this.cbx_operador.Size = new System.Drawing.Size(121, 21);
            this.cbx_operador.TabIndex = 3;
            // 
            // tbx_n2
            // 
            this.tbx_n2.Location = new System.Drawing.Point(305, 113);
            this.tbx_n2.Name = "tbx_n2";
            this.tbx_n2.Size = new System.Drawing.Size(100, 20);
            this.tbx_n2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Segundo número : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operador : ";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(292, 207);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(93, 13);
            this.lbl_msg.TabIndex = 7;
            this.lbl_msg.Text = "Seu  resultado é : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_n2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_operador);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.tbx_n1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_n1;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.ComboBox cbx_operador;
        private System.Windows.Forms.TextBox tbx_n2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_msg;
    }
}

