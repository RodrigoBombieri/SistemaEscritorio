using GestionInventario.Helpers;
using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Enums;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestionInventario.Forms.Movimientos
{
    public partial class RegistrarMovimientoForm : Form
    {
        private readonly IStockService _stockService;
        private readonly IProductoService _productoService;

        public TipoMovimiento Tipo { get; set; }

        public RegistrarMovimientoForm(IStockService stockService, IProductoService productoService)
        {
            InitializeComponent();
            UiStyler.EstilizarFormularioModal(this);
            _stockService = stockService;
            _productoService = productoService;
            Load += RegistrarMovimientoForm_Load;
        }

        private async void RegistrarMovimientoForm_Load(object sender, EventArgs e)
        {
            Text = Tipo switch
            {
                TipoMovimiento.Entrada => "Registrar Entrada",
                TipoMovimiento.Salida => "Registrar Salida",
                TipoMovimiento.Ajuste => "Ajustar Stock",
                _ => "Movimiento de Stock"
            };

            lblCantidad.Text = Tipo == TipoMovimiento.Ajuste ? "Nuevo stock total:" : "Cantidad:";
            numCantidad.Minimum = Tipo == TipoMovimiento.Ajuste ? 0 : 1;

            var productos = (await _productoService.GetAllAsync())
                .Where(p => p.Activo)
                .OrderBy(p => p.Nombre)
                .ToList();

            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
            cmbProducto.DataSource = productos;
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is not Producto producto)
            {
                lblStockActual.Text = string.Empty;
                return;
            }

            lblStockActual.Text = $"Stock actual: {producto.StockActual} (mínimo: {producto.StockMinimo})";

            if (Tipo == TipoMovimiento.Ajuste)
                numCantidad.Value = Math.Min(producto.StockActual, numCantidad.Maximum);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (cmbProducto.SelectedValue == null)
            {
                MostrarError("Seleccioná un producto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MostrarError("El motivo es obligatorio.");
                return;
            }

            var productoId = (int)cmbProducto.SelectedValue;
            var cantidad = (int)numCantidad.Value;
            var motivo = txtMotivo.Text.Trim();
            var usuarioId = SesionActual.UsuarioActual.Id;

            btnGuardar.Enabled = false;
            try
            {
                switch (Tipo)
                {
                    case TipoMovimiento.Entrada:
                        await _stockService.RegistrarEntradaAsync(productoId, cantidad, motivo, usuarioId);
                        break;
                    case TipoMovimiento.Salida:
                        await _stockService.RegistrarSalidaAsync(productoId, cantidad, motivo, usuarioId);
                        break;
                    case TipoMovimiento.Ajuste:
                        await _stockService.RegistrarAjusteAsync(productoId, cantidad, motivo, usuarioId);
                        break;
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
