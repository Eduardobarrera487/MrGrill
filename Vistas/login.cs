using MrGrill.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MrGrill.Controllers;

namespace MrGrill
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            UserRegister newUserRegister = new UserRegister();
            this.Hide();
            newUserRegister.ShowDialog();
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
