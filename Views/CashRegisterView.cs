using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrGrill.Views
{
    public partial class CashRegisterView : Form
    {
        public CashRegisterView()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCaja_MouseEnter(object sender, EventArgs e)
        {
            btnCaja.BackColor = Color.FromArgb(217, 119, 6);
        }

        private void btnCaja_MouseLeave(object sender, EventArgs e)
        {
            btnCaja.BackColor = Color.FromArgb(245, 158, 11);
        }

        private void btnIngresos_MouseEnter(object sender, EventArgs e)
        {
            btnIngresos.BackColor = Color.FromArgb(22, 163, 74);
        }

        private void btnIngresos_MouseLeave(object sender, EventArgs e)
        {
            btnIngresos.BackColor = Color.FromArgb(34, 197, 94);
        }

        private void btnEgresos_MouseEnter(object sender, EventArgs e)
        {
            btnEgresos.BackColor = Color.FromArgb(220, 38, 38);
        }

        private void btnEgresos_MouseLeave(object sender, EventArgs e)
        {
            btnEgresos.BackColor = Color.FromArgb(239, 68, 68);
        }

        private void btnArqueo_MouseEnter(object sender, EventArgs e)
        {
            btnArqueo.BackColor = Color.FromArgb(2, 132, 199);
        }

        private void btnArqueo_MouseLeave(object sender, EventArgs e)
        {
            btnArqueo.BackColor = Color.FromArgb(14, 165, 233);
        }
    }
}
