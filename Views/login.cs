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
using MrGrill.Views;

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
            UserController userController = new UserController();
            Models.User user = new Models.User
            {
                user = txtUser.Texts,
                password = txtPassword.Texts
            };

            try
            {
                if(userController.LoginUser(user))
                {
                    MessageBox.Show("Login exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MrGrillHomeScreen homeScreen = new MrGrillHomeScreen();
                    homeScreen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("An error occurred during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // only trigger on Enter
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true; // prevent "ding" sound
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // only trigger on Enter
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true; // prevent "ding" sound
            }
        }
    }
}
