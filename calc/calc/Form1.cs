using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(v1.Text);
            double valor2 = double.Parse(v2.Text);
            double resultado = valor1 + valor2;
            lbl_resultado.Text = "Seu resultado é : " + resultado;
        }

        private void btn_subtrair_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(v1.Text);
            double valor2 = double.Parse(v2.Text);
            double resultado = valor1 - valor2;
            lbl_resultado.Text = "Seu resultado é : " + resultado;
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(v1.Text);
            double valor2 = double.Parse(v2.Text);
            double resultado = valor1 / valor2;
            lbl_resultado.Text = "Seu resultado é : " + resultado;
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(v1.Text);
            double valor2 = double.Parse(v2.Text);
            double resultado = valor1 * valor2;
            lbl_resultado.Text = "Seu resultado é : " + resultado;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            v1.Text = "";
            v2.Text = "";
            lbl_resultado.Text = "Dados limpos";
        }
    }
}
