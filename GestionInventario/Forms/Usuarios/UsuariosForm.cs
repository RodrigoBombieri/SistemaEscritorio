using GestionInventario.Helpers;
using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario.Forms.Usuarios
{
    public partial class UsuariosForm : Form
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IServiceScopeFactory _scopeFactory;
        private bool _cargando;

        public UsuariosForm(IUsuarioService usuarioService, IServiceScopeFactory scopeFactory)
        {
            InitializeComponent();
            UiStyler.EstilizarFormularioListado(this);
            _usuarioService = usuarioService;
            _scopeFactory = scopeFactory;
            Load += UsuariosForm_Load;
        }

        private async void UsuariosForm_Load(object sender, EventArgs e) => await CargarUsuariosAsync();

        private async Task CargarUsuariosAsync()
        {
            if (_cargando) return;
            _cargando = true;
            SetControlesHabilitados(false);
            try
            {
                var usuarios = (await _usuarioService.GetAllAsync()).AsEnumerable();

                if (chkSoloActivos.Checked)
                    usuarios = usuarios.Where(u => u.Activo);

                var texto = txtBuscar.Text.Trim();
                if (!string.IsNullOrEmpty(texto))
                {
                    usuarios = usuarios.Where(u =>
                        (u.NombreUsuario?.Contains(texto, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (u.NombreCompleto?.Contains(texto, StringComparison.OrdinalIgnoreCase) ?? false));
                }

                dgvUsuarios.Rows.Clear();
                foreach (var u in usuarios.OrderBy(u => u.NombreUsuario))
                {
                    var idx = dgvUsuarios.Rows.Add(u.NombreUsuario, u.NombreCompleto, u.Rol.ToString(), u.Activo ? "Sí" : "No");
                    dgvUsuarios.Rows[idx].Tag = u;
                }

                dgvUsuarios.ClearSelection();
                dgvUsuarios.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargando = false;
                SetControlesHabilitados(true);
            }
        }

        private void SetControlesHabilitados(bool habilitado)
        {
            txtBuscar.Enabled = habilitado;
            chkSoloActivos.Enabled = habilitado;
            btnBuscar.Enabled = habilitado;
            btnRefrescar.Enabled = habilitado;
            btnNuevo.Enabled = habilitado;
            btnEditar.Enabled = habilitado;
            btnCambiarPassword.Enabled = habilitado;
            btnDesactivar.Enabled = habilitado;
        }

        private Usuario ObtenerUsuarioSeleccionado()
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un usuario de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return (Usuario)dgvUsuarios.CurrentRow.Tag;
        }

        private bool AbrirFormularioEdicion(int? usuarioId)
        {
            using var scope = _scopeFactory.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<UsuarioEditForm>();
            form.UsuarioId = usuarioId;
            return form.ShowDialog(this) == DialogResult.OK;
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioEdicion(null))
                await CargarUsuariosAsync();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var usuario = ObtenerUsuarioSeleccionado();
            if (usuario == null) return;

            if (AbrirFormularioEdicion(usuario.Id))
                await CargarUsuariosAsync();
        }

        private void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            var usuario = ObtenerUsuarioSeleccionado();
            if (usuario == null) return;

            using var scope = _scopeFactory.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<CambiarPasswordForm>();
            form.UsuarioId = usuario.Id;
            form.NombreUsuario = usuario.NombreUsuario;
            form.ShowDialog(this);
        }

        private async void btnDesactivar_Click(object sender, EventArgs e)
        {
            var usuario = ObtenerUsuarioSeleccionado();
            if (usuario == null) return;

            if (usuario.Id == SesionActual.UsuarioActual?.Id)
            {
                MessageBox.Show("No podés desactivar tu propio usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!usuario.Activo)
            {
                MessageBox.Show("El usuario ya está desactivado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmar = MessageBox.Show(
                $"¿Desactivar al usuario '{usuario.NombreUsuario}'?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            try
            {
                await _usuarioService.DesactivarAsync(usuario.Id);
                await CargarUsuariosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al desactivar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e) => await CargarUsuariosAsync();

        private async void chkSoloActivos_CheckedChanged(object sender, EventArgs e) => await CargarUsuariosAsync();

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            await CargarUsuariosAsync();
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
    }
}