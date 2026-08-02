using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Enums;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace GestionInventario.Forms.Usuarios
{
    public partial class UsuarioEditForm : Form
    {
        private readonly IUsuarioService _usuarioService;
        private Usuario _usuario;

        public int? UsuarioId { get; set; }

        public UsuarioEditForm(IUsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            cmbRol.DataSource = Enum.GetValues(typeof(RolUsuario));
            Load += UsuarioEditForm_Load;
        }

        private async void UsuarioEditForm_Load(object sender, EventArgs e)
        {
            Text = UsuarioId.HasValue ? "Editar Usuario" : "Nuevo Usuario";

            if (UsuarioId.HasValue)
            {
                _usuario = await _usuarioService.GetByIdAsync(UsuarioId.Value);
                if (_usuario == null)
                {
                    MessageBox.Show("El usuario no existe o fue eliminado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                txtNombreUsuario.Text = _usuario.NombreUsuario;
                txtNombreCompleto.Text = _usuario.NombreCompleto;
                cmbRol.SelectedItem = _usuario.Rol;

                txtNombreUsuario.Enabled = false;
                panelPassword.Visible = false;
            }
            else
            {
                _usuario = new Usuario();
                panelPassword.Visible = true;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MostrarError("El nombre de usuario es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                MostrarError("El nombre completo es obligatorio.");
                return;
            }

            if (cmbRol.SelectedItem == null)
            {
                MostrarError("Seleccioná un rol.");
                return;
            }

            var rol = (RolUsuario)cmbRol.SelectedItem;

            if (!UsuarioId.HasValue)
            {
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
            }

            btnGuardar.Enabled = false;
            try
            {
                if (UsuarioId.HasValue)
                {
                    _usuario.NombreCompleto = txtNombreCompleto.Text.Trim();
                    _usuario.Rol = rol;
                    await _usuarioService.ActualizarAsync(_usuario);
                }
                else
                {
                    await _usuarioService.CrearUsuarioAsync(
                        txtNombreUsuario.Text.Trim(),
                        txtPassword.Text,
                        txtNombreCompleto.Text.Trim(),
                        rol);
                }

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