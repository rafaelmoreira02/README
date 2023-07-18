using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homepage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            string nome = tbx_nome.Text;
            string senha = tbx_senha.Text;
            lbl_texto.Text = "Bem-Vindo " + nome + ", Sua senha é " + senha;
        }
    }
}
