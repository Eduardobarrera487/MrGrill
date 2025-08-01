using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MrGrill.Controllers;
using MrGrill.Models;

namespace MrGrill.Vistas
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add("Activo");
            cmbEstado.Items.Add("Inactivo");
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Usuario");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User newUser = new User
            {
                name = txtNombre.Text,
                user = txtUsuario.Text,
                password = txtClave.Text,
                role = cmbRol.SelectedItem.ToString(),
                state = cmbEstado.SelectedItem.ToString() == "Activo"
            };
            UserController userController = new UserController();
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("Por favor completá todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                userController.RegisterUser(newUser);
                MessageBox.Show("Usuario registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the registration form after successful registration
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtName__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
