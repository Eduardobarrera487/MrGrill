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
            if (cashRegisterView == null)
            {
                cashRegisterView = new CashRegisterView();
                cashRegisterView.FormClosed += cashRegisterView_FormClosed;
                cashRegisterView.MdiParent = this; // Set the parent form for MDI
                cashRegisterView.Show();
            }else
            {
                cashRegisterView.Activate(); // Bring the existing form to the front
            }
        }

        private void cashRegisterView_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
