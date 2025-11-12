using Microsoft.VisualBasic;
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
    public partial class frmexe3 : Form
    {
        public frmexe3()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int totalC = Convert.ToInt32(txtqtd.Text);
            int i = 1;
            double areaT = 0;

            while (i <= totalC)
            {
                double largura = Convert.ToDouble(
                      Interaction.InputBox($"Digite a largura do cômodo {i} (m):", "Largura")); ;
                double comprimento = Convert.ToDouble(
                      Interaction.InputBox($"Digite o comprimento do cômodo {i} (m):", "Comprimento"));

                double areaComodo = largura * comprimento;
                areaT += areaComodo;
                txtC.Text += $"Cômodo {i}: {areaComodo:F2} m²{Environment.NewLine}";
                i++;
                txttotal.Text = $"{areaT:F2} m²";
            }
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            int totalC = Convert.ToInt32(txtqtd.Text);
            int i = 1;
            double areaT = 0;
            do
            {
                double largura = Convert.ToDouble(
                      Interaction.InputBox($"Digite a largura do cômodo {i} (m):", "Largura")); ;
                double comprimento = Convert.ToDouble(
                      Interaction.InputBox($"Digite o comprimento do cômodo {i} (m):", "Comprimento"));

                double areaComodo = largura * comprimento;
                areaT += areaComodo;
                txtC.Text += $"Cômodo {i}: {areaComodo:F2} m²{Environment.NewLine}";
                i++;
            }
            while (i <= totalC);
            txttotal.Text = $"{areaT:F2} m²";
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int totalC = Convert.ToInt32(txtqtd.Text);
            int i;
            double areaT = 0;

            for (i = 1; i <= totalC; i++)
            {
                double largura = Convert.ToDouble(
                      Interaction.InputBox($"Digite a largura do cômodo {i} (m):", "Largura")); ;
                double comprimento = Convert.ToDouble(
                      Interaction.InputBox($"Digite o comprimento do cômodo {i} (m):", "Comprimento"));

                double areaComodo = largura * comprimento;
                areaT += areaComodo;
                txtC.Text += $"Cômodo {i}: {areaComodo:F2} m²{Environment.NewLine}";
                i++;
                txttotal.Text = $"{areaT:F2} m²";
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttotal.Clear();
            txtqtd.Clear();
            txtC.Clear();
            txtqtd.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
