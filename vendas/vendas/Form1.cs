using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double qtd = double.Parse(tbx_qtd.Text);
            double preco = double.Parse(tbx_preco.Text);
            double valor = qtd * preco;
            string opcao = cbx_metodo.Text;
            double desconto = valor * 0.1;
            if (opcao == "A vista") 
            {
                lbl_msg.Text = "VALOR A PAGAR : " + (valor - desconto);
            }
            if (opcao == "Prazo")
            {
                lbl_msg.Text = "VALOR A PAGAR : " + valor;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
