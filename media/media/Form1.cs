using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media
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
            double n3 = double.Parse(tbx_n3.Text);
            double media = (n1 + n2 + n3) / 3;
            lbl_media.Text = "SUA MÉDIA FOI : " + media;
            if (media >= 7)
            { lbl_msg.Text = "VOCÊ FOI APRVADO, PARABÉNS!"; }
            else
            { lbl_msg.Text = "VOCÊ FOI REPROVADO, TENTE NA PRÓXIMA."; }

        }
    }
}
