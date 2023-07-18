namespace vendas
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
            this.tbx_qtd = new System.Windows.Forms.TextBox();
            this.tbx_preco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_metodo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade : ";
            // 
            // tbx_qtd
            // 
            this.tbx_qtd.Location = new System.Drawing.Point(225, 87);
            this.tbx_qtd.Name = "tbx_qtd";
            this.tbx_qtd.Size = new System.Drawing.Size(100, 20);
            this.tbx_qtd.TabIndex = 1;
            // 
            // tbx_preco
            // 
            this.tbx_preco.Location = new System.Drawing.Point(225, 120);
            this.tbx_preco.Name = "tbx_preco";
            this.tbx_preco.Size = new System.Drawing.Size(100, 20);
            this.tbx_preco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(210, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Formas de Pagamento";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(250, 245);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(230, 281);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(102, 13);
            this.lbl_msg.TabIndex = 7;
            this.lbl_msg.Text = "VALOR A PAGAR : ";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(230, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Informações";
            // 
            // cbx_metodo
            // 
            this.cbx_metodo.FormattingEnabled = true;
            this.cbx_metodo.Items.AddRange(new object[] {
            "A vista",
            "Prazo"});
            this.cbx_metodo.Location = new System.Drawing.Point(225, 218);
            this.cbx_metodo.Name = "cbx_metodo";
            this.cbx_metodo.Size = new System.Drawing.Size(121, 21);
            this.cbx_metodo.TabIndex = 11;
            this.cbx_metodo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbx_metodo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_preco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_qtd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_qtd;
        private System.Windows.Forms.TextBox tbx_preco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_metodo;
    }
}

