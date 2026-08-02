using GestionInventario.Helpers;
using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Enums;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace GestionInventario.Forms.Usuarios
{
    public partial class CambiarPasswordForm : Form
    {
        private readonly IUsuarioService _usuarioService;

        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }

        public CambiarPasswordForm(IUsuarioService usuarioService)
        {
            InitializeComponent();
            UiStyler.EstilizarFormularioModal(this);
            _usuarioService = usuarioService;
            Load += CambiarPasswordForm_Load;
        }

        private void CambiarPasswordForm_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {NombreUsuario}";
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MostrarError("La contraseña es obligatoria.");
                return;
            }

            if (txtPassword.Text != txtConfirmarPassword.Text)
            {
                MostrarError("Las contraseñas no coinciden.");
                return;
            }

            btnGuardar.Enabled = false;
            try
            {
                await _usuarioService.CambiarPasswordAsync(UsuarioId, txtPassword.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MostrarError(ex.Message);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private void MostrarError(string mensaje)
        {
            lblError.Text = mensaje;
            lblError.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
