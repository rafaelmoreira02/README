using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(tbx_n1.Text);
            double n2 = double.Parse(tbx_n2.Text);
            string operador = cbx_operador.Text;
            if (operador == "Somar")
            {
                double soma = n1 + n2;
                lbl_msg.Text = "Seu resultado é : " + soma;
            }
            if (operador == "Multiplicar")
            {
                double multi = n1 * n2;
                lbl_msg.Text = "Seu resultado é : " + multi;
            }
        }
    }
}
