using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
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
    public partial class ProveedorEditForm : Form
    {
        private readonly IProveedorService _proveedorService;
        private Proveedor _proveedor;

        public int? ProveedorId { get; set; }

        public ProveedorEditForm(IProveedorService proveedorService)
        {
            InitializeComponent();
            _proveedorService = proveedorService;
            Load += ProveedorEditForm_Load;
        }

        private async void ProveedorEditForm_Load(object sender, EventArgs e)
        {
            Text = ProveedorId.HasValue ? "Editar Proveedor" : "Nuevo Proveedor";

            if (ProveedorId.HasValue)
            {
                _proveedor = await _proveedorService.GetByIdAsync(ProveedorId.Value);
                if (_proveedor == null)
                {
                    MessageBox.Show("Proveedor no encontrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                txtRazonSocial.Text = _proveedor.RazonSocial;
                txtCUIT.Text = _proveedor.CUIT;
                txtTelefono.Text = _proveedor.Telefono;
                txtEmail.Text = _proveedor.Email;
                txtDireccion.Text = _proveedor.Direccion;
            }
            else
            {
                _proveedor = new Proveedor();
            }

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                lblError.Text = "La razón social es obligatoria.";
                lblError.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCUIT.Text))
            {
                lblError.Text = "El CUIT es obligatorio.";
                lblError.Visible = true;
                return;
            }

            _proveedor.RazonSocial = txtRazonSocial.Text.Trim();
            _proveedor.CUIT = txtCUIT.Text.Trim();
            _proveedor.Telefono = txtTelefono.Text.Trim();
            _proveedor.Email = txtEmail.Text.Trim();
            _proveedor.Direccion = txtDireccion.Text.Trim();

            btnGuardar.Enabled = false;
            try
            {
                if (ProveedorId.HasValue)
                {
                    await _proveedorService.ActualizarAsync(_proveedor);
                }
                else
                {
                    await _proveedorService.CrearAsync(_proveedor);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MostrarError($"Error al guardar el proveedor: {ex.Message}");
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
