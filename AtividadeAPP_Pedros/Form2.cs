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
    public partial class frmexe1 : Form
    {
        public frmexe1()
        {
            InitializeComponent();
        }

        private void btnw_Click(object sender, EventArgs e)
        {
            int num, produto = 0, i = 1;
            string tabuada = "";
            num = Convert.ToInt32(txtnum.Text);
            if (num < 10 && num > 0)
            {
                while (i <= 10)
                {
                    produto += num;
                    tabuada += produto.ToString(); 
                    tabuada += ",";
                    i++;
                }
                txtresult.Text = tabuada;
            }
            else
            {
                MessageBox.Show("O programa lê somente números de 1 a 9");
                txtnum.Clear();
            }

        }

        private void frmexe1_Load(object sender, EventArgs e)
        {

        }

        private void brndow_Click(object sender, EventArgs e)
        {
            int num, produto = 0, i = 1;
            string tabuada = "";
            num = Convert.ToInt32(txtnum.Text);
            if (num < 10 && num > 0)
            {
                do
                {
                    produto += num;
                    tabuada += produto.ToString();
                    tabuada += ",";
                    i++;
                } while (i <= 10);
                txtresult.Text = tabuada;
            }
            else
            {
                MessageBox.Show("O programa lê somente números de 1 a 9");
                txtnum.Clear();
            }
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int num, produto = 0;
            string tabuada = "";
            num = Convert.ToInt32(txtnum.Text);
            if (num < 10 && num > 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    produto += num;
                    tabuada += produto.ToString();
                    tabuada += ",";
                }
                txtresult.Text = tabuada;
            }
            else
            {
                MessageBox.Show("O programa lê apenas números de 1 a 9");
                txtnum.Clear();
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
            txtnum.Focus();
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
