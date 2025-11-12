using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAPP_Pedros
{
    public partial class frmexe2 : Form
    {
        public frmexe2()
        {
            InitializeComponent();
        }

        private void btnw_Click(object sender, EventArgs e)
        {
            int i = 10;
            double f;
            while (i <= 100)
            {
                f = (i * 1.8) + 32;
                txtc.Text += String.Format("\n" + i.ToString());
                txtf.Text += String.Format("\n" + f.ToString());
                i += 10;
            }
        }

        private void brndow_Click(object sender, EventArgs e)
        {
            int i = 10;
            double f;
            do
            {
                f = (i * 1.8) + 32;
                txtc.Text += String.Format("\n" + i.ToString());
                txtf.Text += String.Format("\n" + f.ToString());
                i += 10;
            } while (i <= 100);
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            double f;
            for (int i = 10; i <= 100; i += 10)
            {
                f = (i * 1.8) + 32;
                txtc.Text += String.Format("\n" + i.ToString());
                txtf.Text += String.Format("\n" + f.ToString());
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
           txtc.Clear();
           txtc.Clear();
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
