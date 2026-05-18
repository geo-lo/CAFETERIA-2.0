using Proyecto_PED_CAFETERIA.Clases;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_PED_CAFETERIA.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ValidarAdministrador();
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarAdministrador();
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContrasena.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidarAdministrador()
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (usuario == "admin" && contrasena == "1234")
            {
                SesionActual.Usuario = "Administrador";
                SesionActual.Rol = "admin";

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblError.Text = "Usuario o contraseña incorrectos.";
                txtContrasena.Clear();
                txtContrasena.Focus();
            }
        }
    }
}