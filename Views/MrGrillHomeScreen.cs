using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrGrill.Views;

namespace MrGrill.Views
{
    public partial class MrGrillHomeScreen : Form
    {
        bool isSidebarOpen = false;
        CashRegisterView cashRegisterView; 

        public MrGrillHomeScreen()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void MrGrillHomeScreen_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SideBarButton_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            SideBarTimer.Interval = 5; // Adjust the interval for smoother animation
            if(isSidebarOpen)
            {
                if (SideBarLayaout.Width > 70)
                {
                    SideBarLayaout.Width -= 5;
                }
                else
                {
                    SideBarTimer.Stop();
                    isSidebarOpen = false;
                }
            }
            else
            {
                if (SideBarLayaout.Width < 234)
                {
                    SideBarLayaout.Width += 5;
                }
                else
                {
                    SideBarTimer.Stop();
                    isSidebarOpen = true;
                }
            }
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new CashRegisterView());
        }

        private void cashRegisterView_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
        //funcion para cerrar o desplegar el formulario hijo
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnIngredientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IngredientesView());
        }
    }


}
