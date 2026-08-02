using GestionInventario.Helpers;
using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario.Forms.Proveedores
{
    public partial class ProveedoresForm : Form
    {
        private readonly IProveedorService _proveedorService;
        private readonly IServiceScopeFactory _scopeFactory;
        private bool _cargando;

        public ProveedoresForm(IProveedorService proveedorService, IServiceScopeFactory scopeFactory)
        {
            InitializeComponent();
            UiStyler.EstilizarFormularioListado(this);
            _proveedorService = proveedorService;
            _scopeFactory = scopeFactory;
            Load += ProveedoresForm_Load;
        }

        private async void ProveedoresForm_Load(object sender, EventArgs e) => await CargarProveedoresAsync();

        private async Task CargarProveedoresAsync()
        {
            if (_cargando) return;
            _cargando = true;
            SetControlesHabilitados(false);
            try
            {
                var proveedores = (await _proveedorService.GetAllAsync()).AsEnumerable();

                if (chkSoloActivos.Checked)
                    proveedores = proveedores.Where(p => p.Activo);

                var texto = txtBuscar.Text.Trim();

                if (!string.IsNullOrEmpty(texto))
                {
                    proveedores = proveedores.Where(p =>
                        (p.RazonSocial?.Contains(texto, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (p.CUIT?.Contains(texto, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (p.Telefono?.Contains(texto, StringComparison.OrdinalIgnoreCase) ?? false) ||
                        (p.Direccion?.Contains(texto, StringComparison.OrdinalIgnoreCase) ?? false));
                }
                dgvProveedores.Rows.Clear();
                foreach (var p in proveedores.OrderBy(p => p.RazonSocial))
                {
                    var idx = dgvProveedores.Rows.Add(p.RazonSocial, p.CUIT, p.Telefono , p.Email, p.Direccion, p.Activo ? "Sí" : "No");
                    dgvProveedores.Rows[idx].Tag = p;
                }

                dgvProveedores.ClearSelection();
                dgvProveedores.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            btnBuscar.Enabled = habilitado;
            btnRefrescar.Enabled = habilitado;
            btnNuevo.Enabled = habilitado;
            btnEditar.Enabled = habilitado;
            btnDesactivar.Enabled = habilitado;
        }

        private Proveedor ObtenerProveedorSeleccionado()
        {
            if (dgvProveedores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un proveedor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return (Proveedor)dgvProveedores.CurrentRow.Tag;
        }

        private bool AbrirFormularioEdicion(int? proveedorId)
        {
            using var scope = _scopeFactory.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<ProveedorEditForm>();
            form.ProveedorId = proveedorId;
            return form.ShowDialog(this) == DialogResult.OK;
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioEdicion(null))
                await CargarProveedoresAsync();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var proveedor = ObtenerProveedorSeleccionado();
            if (proveedor == null) return;
            if (AbrirFormularioEdicion(proveedor.Id))
                await CargarProveedoresAsync();
        }

        private async void btnDesactivar_Click(object sender, EventArgs e)
        {
            var proveedor = ObtenerProveedorSeleccionado();
            if (proveedor == null) return;

            var confirmResult = MessageBox.Show(
                $"¿Está seguro de desactivar el proveedor '{proveedor.RazonSocial}'?",
                "Confirmar Desactivación", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes) return;

            try
            {
                await _proveedorService.DesactivarAsync(proveedor.Id);
                await CargarProveedoresAsync();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Error al desactivar el proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnBuscar_Click(object sender, EventArgs e) => await CargarProveedoresAsync();

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            await CargarProveedoresAsync();
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
        private async void chkSoloActivos_CheckedChanged(object sender, EventArgs e) => await CargarProveedoresAsync();

    }
}
