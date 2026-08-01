using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario.Forms.Productos
{
    public partial class ProductosForm : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;
        private readonly IProveedorService _proveedorService;
        private readonly IServiceScopeFactory _scopeFactory;

        private Dictionary<int, string> _nombresCategoria = new();
        private Dictionary<int, string> _nombresProveedor = new();

        public ProductosForm(
            IProductoService productoService,
            ICategoriaService categoriaService,
            IProveedorService proveedorService,
            IServiceScopeFactory scopeFactory)
        {
            InitializeComponent();
            _productoService = productoService;
            _categoriaService = categoriaService;
            _proveedorService = proveedorService;
            _scopeFactory = scopeFactory;
            Load += ProductosForm_Load;
        }

        private async void ProductosForm_Load(object sender, EventArgs e)
        {
            await CargarCombosAsync();
            await CargarProductosAsync();
        }

        private async Task CargarCombosAsync()
        {
            var categorias = (await _categoriaService.GetAllAsync()).ToList();
            _nombresCategoria = categorias.ToDictionary(c => c.Id, c => c.Nombre);

            var proveedores = (await _proveedorService.GetAllAsync()).ToList();
            _nombresProveedor = proveedores.ToDictionary(p => p.Id, p => p.RazonSocial);

            var itemsCombo = new List<Categoria> { new Categoria { Id = 0, Nombre = "(Todas)" } };
            itemsCombo.AddRange(categorias);

            cmbCategoria.SelectedIndexChanged -= cmbCategoria_SelectedIndexChanged;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = itemsCombo;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
        }

        private bool _cargando;

        private async Task CargarProductosAsync()
        {
            if (_cargando) return;
            _cargando = true;
            SetControlesFiltroHabilitados(false);
            try
            {
                var categoriaId = (int)(cmbCategoria.SelectedValue ?? 0);
                var soloStockBajo = chkSoloStockBajo.Checked;
                var texto = txtBuscar.Text.Trim();

                IEnumerable<Producto> productos = soloStockBajo
                    ? await _productoService.GetConStockBajoAsync()
                    : categoriaId > 0
                        ? await _productoService.GetByCategoriaAsync(categoriaId)
                        : await _productoService.GetAllAsync();

                if (!string.IsNullOrWhiteSpace(texto))
                {
                    productos = productos.Where(p =>
                        p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                        p.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase));
                }

                dgvProductos.Rows.Clear();

                foreach (var p in productos.OrderBy(p => p.Nombre))
                {
                    var nombreCategoria = _nombresCategoria.TryGetValue(p.CategoriaId, out var c) ? c : "-";
                    var nombreProveedor = p.ProveedorId.HasValue && _nombresProveedor.TryGetValue(p.ProveedorId.Value, out var pr) ? pr : "-";

                    var idx = dgvProductos.Rows.Add(
                        p.Codigo, p.Nombre, nombreCategoria, nombreProveedor,
                        p.PrecioVenta.ToString("C2"), p.StockActual, p.StockMinimo,
                        p.Activo ? "Sí" : "No");

                    var fila = dgvProductos.Rows[idx];
                    fila.Tag = p;

                    if (!p.Activo)
                        fila.DefaultCellStyle.ForeColor = Color.Gray;
                    else if (p.StockActual <= p.StockMinimo)
                        fila.DefaultCellStyle.ForeColor = Color.Firebrick;
                }
            }
            finally
            {
                _cargando = false;
                SetControlesFiltroHabilitados(true);
            }
        }

        private void SetControlesFiltroHabilitados(bool habilitado)
        {
            txtBuscar.Enabled = habilitado;
            btnBuscar.Enabled = habilitado;
            cmbCategoria.Enabled = habilitado;
            chkSoloStockBajo.Enabled = habilitado;
            btnRefrescar.Enabled = habilitado;
            btnNuevo.Enabled = habilitado;
            btnEditar.Enabled = habilitado;
            btnDesactivar.Enabled = habilitado;
        }

        private Producto ObtenerProductoSeleccionado()
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un producto de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return (Producto)dgvProductos.CurrentRow.Tag;
        }

        private bool AbrirFormularioEdicion(int? productoId)
        {
            using var scope = _scopeFactory.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<ProductoEditForm>();
            form.ProductoId = productoId;
            return form.ShowDialog(this) == DialogResult.OK;
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioEdicion(null))
                await CargarProductosAsync();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var producto = ObtenerProductoSeleccionado();
            if (producto == null) return;

            if (AbrirFormularioEdicion(producto.Id))
                await CargarProductosAsync();
        }

        private async void btnDesactivar_Click(object sender, EventArgs e)
        {
            var producto = ObtenerProductoSeleccionado();
            if (producto == null) return;

            if (!producto.Activo)
            {
                MessageBox.Show("El producto ya está desactivado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmar = MessageBox.Show(
                $"¿Desactivar el producto '{producto.Nombre}'?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            await _productoService.DesactivarAsync(producto.Id);
            await CargarProductosAsync();
        }

        private async void btnBuscar_Click(object sender, EventArgs e) => await CargarProductosAsync();

        private async void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e) => await CargarProductosAsync();

        private async void chkSoloStockBajo_CheckedChanged(object sender, EventArgs e) => await CargarProductosAsync();

        private async void btnRefrescar_Click(object sender, EventArgs e) => await CargarProductosAsync();

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
    }
}