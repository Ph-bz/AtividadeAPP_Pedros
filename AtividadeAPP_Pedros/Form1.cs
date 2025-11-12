using AtividadeAPP_Pedros;
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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void tsmiexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiexe1_Click(object sender, EventArgs e)
        {
            Hide();
            frmexe1 exe1 = new frmexe1();
            exe1.Show();
        }

        private void tsmiexe2_Click(object sender, EventArgs e)
        {
            Hide();
            frmexe2 exe2 = new frmexe2();
            exe2.Show();
        }

        private void tsmiexe3_Click(object sender, EventArgs e)
        {
            Hide();
            frmexe3 exe3 = new frmexe3();
            exe3.Show();
        }
    }
}
