using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geometria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_montante_Click(object sender, EventArgs e)
        {
            double capital = double.Parse(tbx_capital.Text);
            double taxa = double.Parse(tbx_taxa_juros.Text);
            double tempo = double.Parse(tbx_tempo.Text);
            double valor_montante = capital * Math.Pow( 1 + (taxa/100), tempo);
            lbl_montante.Text = "O valor do Montante é : " + valor_montante.ToString();
        }

        private void btn_juros_Click(object sender, EventArgs e)
        {
            double capital = double.Parse(tbx_capital2.Text);
            double montante = double.Parse(tbx_montante.Text);
            double valor_juros = montante - capital;
            lbl_juros.Text = "O valor do Juros é : " + valor_juros;
        }
    }
}
