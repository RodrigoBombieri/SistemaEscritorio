using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestionInventario.Forms.Productos
{
    public partial class ProductoEditForm : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;
        private readonly IProveedorService _proveedorService;
        private Producto _producto;

        public int? ProductoId { get; set; }

        public ProductoEditForm(
            IProductoService productoService,
            ICategoriaService categoriaService,
            IProveedorService proveedorService)
        {
            InitializeComponent();
            _productoService = productoService;
            _categoriaService = categoriaService;
            _proveedorService = proveedorService;
            Load += ProductoEditForm_Load;
        }

        private async void ProductoEditForm_Load(object sender, EventArgs e)
        {
            Text = ProductoId.HasValue ? "Editar Producto" : "Nuevo Producto";

            var categorias = (await _categoriaService.GetAllAsync()).ToList();
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = categorias;

            var proveedores = (await _proveedorService.GetAllAsync()).Where(p => p.Activo).ToList();
            proveedores.Insert(0, new Proveedor { Id = 0, RazonSocial = "(Sin proveedor)" });
            cmbProveedor.DisplayMember = "RazonSocial";
            cmbProveedor.ValueMember = "Id";
            cmbProveedor.DataSource = proveedores;

            if (ProductoId.HasValue)
            {
                _producto = await _productoService.GetByIdAsync(ProductoId.Value);
                if (_producto == null)
                {
                    MessageBox.Show("El producto no existe o fue eliminado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                txtCodigo.Text = _producto.Codigo;
                txtNombre.Text = _producto.Nombre;
                txtDescripcion.Text = _producto.Descripcion;
                cmbCategoria.SelectedValue = _producto.CategoriaId;
                cmbProveedor.SelectedValue = _producto.ProveedorId ?? 0;
                numPrecioCosto.Value = _producto.PrecioCosto;
                numPrecioVenta.Value = _producto.PrecioVenta;
                numStockActual.Value = _producto.StockActual;
                numStockMinimo.Value = _producto.StockMinimo;

                numStockActual.Enabled = false;
                lblStockNota.Visible = true;
            }
            else
            {
                _producto = new Producto();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MostrarError("Código y nombre son obligatorios.");
                return;
            }

            if (cmbCategoria.SelectedValue == null)
            {
                MostrarError("Seleccioná una categoría.");
                return;
            }

            _producto.Codigo = txtCodigo.Text.Trim();
            _producto.Nombre = txtNombre.Text.Trim();
            _producto.Descripcion = txtDescripcion.Text.Trim();
            _producto.CategoriaId = (int)cmbCategoria.SelectedValue;

            var proveedorId = (int)cmbProveedor.SelectedValue;
            _producto.ProveedorId = proveedorId == 0 ? (int?)null : proveedorId;

            _producto.PrecioCosto = numPrecioCosto.Value;
            _producto.PrecioVenta = numPrecioVenta.Value;
            _producto.StockMinimo = (int)numStockMinimo.Value;

            btnGuardar.Enabled = false;
            try
            {
                if (ProductoId.HasValue)
                {
                    await _productoService.ActualizarAsync(_producto);
                }
                else
                {
                    _producto.StockActual = (int)numStockActual.Value;
                    await _productoService.CrearAsync(_producto);
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