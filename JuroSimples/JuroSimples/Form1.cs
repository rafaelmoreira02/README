using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double capital = double.Parse(tbx_capital.Text);
            double taxa = double.Parse(tbx_taxa.Text);
            double tempo = double.Parse(tbx_tempo.Text);
            double resultado = capital * (taxa/100) * tempo;
            lbl_juros.Text = "Valor do juros : " + resultado.ToString() + "R$";
        }
    }
}
