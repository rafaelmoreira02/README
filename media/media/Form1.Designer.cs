namespace media
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
            this.tbx_n2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_n3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_media = new System.Windows.Forms.Label();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRIMEIRA NOTA : ";
            // 
            // tbx_n1
            // 
            this.tbx_n1.Location = new System.Drawing.Point(285, 88);
            this.tbx_n1.Name = "tbx_n1";
            this.tbx_n1.Size = new System.Drawing.Size(52, 20);
            this.tbx_n1.TabIndex = 1;
            // 
            // tbx_n2
            // 
            this.tbx_n2.Location = new System.Drawing.Point(285, 119);
            this.tbx_n2.Name = "tbx_n2";
            this.tbx_n2.Size = new System.Drawing.Size(52, 20);
            this.tbx_n2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SEGUNDA NOTA : ";
            // 
            // tbx_n3
            // 
            this.tbx_n3.Location = new System.Drawing.Point(285, 150);
            this.tbx_n3.Name = "tbx_n3";
            this.tbx_n3.Size = new System.Drawing.Size(52, 20);
            this.tbx_n3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TERCEIRA NOTA : ";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(274, 214);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "CALCULAR";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(254, 186);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(95, 13);
            this.lbl_media.TabIndex = 7;
            this.lbl_media.Text = "SUA MÉDIA FOI : ";
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(414, 122);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 13);
            this.lbl_msg.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.lbl_media);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.tbx_n3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_n2);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.TextBox tbx_n2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_n3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.Label lbl_msg;
    }
}

