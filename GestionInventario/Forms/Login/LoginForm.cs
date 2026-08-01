using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInventario.Helpers;
using GestorInventario.Application.Interfaces;
using System;
using System.Windows.Forms;

namespace GestionInventario.Forms.Login
{
    public partial class LoginForm : Form
    {
        private readonly IUsuarioService _usuarioService;

        public LoginForm(IUsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblError.Text = "Ingresá usuario y contraseña.";
                lblError.Visible = true;
                return;
            }

            btnIngresar.Enabled = false;
            try
            {
                var usuario = await _usuarioService.AutenticarAsync(txtUsuario.Text.Trim(), txtPassword.Text);

                if (usuario == null)
                {
                    lblError.Text = "Usuario o contraseña incorrectos.";
                    lblError.Visible = true;
                    return;
                }

                SesionActual.UsuarioActual = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "Error al iniciar sesión: " + ex.Message;
                lblError.Visible = true;
            }
            finally
            {
                btnIngresar.Enabled = true;
            }
        }
    }
}
