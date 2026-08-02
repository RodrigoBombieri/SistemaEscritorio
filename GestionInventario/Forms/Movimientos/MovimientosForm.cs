using GestionInventario.Helpers;
using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario.Forms.Movimientos
{
    public partial class MovimientosForm : Form
    {
        private readonly IStockService _stockService;
        private readonly IProductoService _productoService;
        private readonly IServiceScopeFactory _scopeFactory;
        private bool _cargando;

        public MovimientosForm(IStockService stockService, IProductoService productoService, IServiceScopeFactory scopeFactory)
        {
            InitializeComponent();
            UiStyler.EstilizarFormularioListado(this);
            _stockService = stockService;
            _productoService = productoService;
            _scopeFactory = scopeFactory;
            Load += MovimientosForm_Load;
        }

        private async void MovimientosForm_Load(object sender, EventArgs e)
        {
            await CargarProductosAsync();
            CargarTipos();
            await CargarMovimientosAsync();
        }

        private async Task CargarProductosAsync()
        {
            var productos = (await _productoService.GetAllAsync()).OrderBy(p => p.Nombre).ToList();

            var itemsCombo = new List<Producto> { new Producto { Id = 0, Nombre = "(Todos)" } };
            itemsCombo.AddRange(productos);

            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
            cmbProducto.DataSource = itemsCombo;
        }

        private void CargarTipos()
        {
            cmbTipo.Items.Add("(Todos)");
            cmbTipo.Items.Add(TipoMovimiento.Entrada);
            cmbTipo.Items.Add(TipoMovimiento.Salida);
            cmbTipo.Items.Add(TipoMovimiento.Ajuste);
            cmbTipo.SelectedIndex = 0;
        }

        private async Task CargarMovimientosAsync()
        {
            if (_cargando) return;
            _cargando = true;
            SetControlesHabilitados(false);
            try
            {
                var productoId = (int)(cmbProducto.SelectedValue ?? 0);

                IEnumerable<MovimientoStock> movimientos = chkFiltrarFecha.Checked
                    ? await _stockService.GetByFechaAsync(dtpDesde.Value.Date, dtpHasta.Value.Date.AddDays(1).AddSeconds(-1))
                    : productoId > 0
                        ? await _stockService.GetByProductoAsync(productoId)
                        : await _stockService.GetAllAsync();

                // Si se filtró por fecha, el producto todavía puede acotarse del lado del cliente.
                if (chkFiltrarFecha.Checked && productoId > 0)
                    movimientos = movimientos.Where(m => m.ProductoId == productoId);

                if (cmbTipo.SelectedItem is TipoMovimiento tipo)
                    movimientos = movimientos.Where(m => m.Tipo == tipo);

                dgvMovimientos.Rows.Clear();
                foreach (var m in movimientos.OrderByDescending(m => m.Fecha))
                {
                    var idx = dgvMovimientos.Rows.Add(
                        m.Fecha.ToString("dd/MM/yyyy HH:mm"),
                        m.Producto?.Nombre ?? "-",
                        m.Tipo.ToString(),
                        m.Cantidad,
                        m.Motivo,
                        m.Usuario?.NombreCompleto ?? "-");

                    var fila = dgvMovimientos.Rows[idx];
                    fila.Tag = m;
                    fila.DefaultCellStyle.ForeColor = m.Tipo switch
                    {
                        TipoMovimiento.Entrada => UiTheme.EstadoNormalTexto,
                        TipoMovimiento.Salida => UiTheme.EstadoAlertaTexto,
                        _ => UiTheme.TextoPrimario
                    };
                }

                dgvMovimientos.ClearSelection();
                dgvMovimientos.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los movimientos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargando = false;
                SetControlesHabilitados(true);
            }
        }

        private void SetControlesHabilitados(bool habilitado)
        {
            cmbProducto.Enabled = habilitado;
            cmbTipo.Enabled = habilitado;
            chkFiltrarFecha.Enabled = habilitado;
            dtpDesde.Enabled = habilitado && chkFiltrarFecha.Checked;
            dtpHasta.Enabled = habilitado && chkFiltrarFecha.Checked;
            btnBuscar.Enabled = habilitado;
            btnRefrescar.Enabled = habilitado;
            btnEntrada.Enabled = habilitado;
            btnSalida.Enabled = habilitado;
            btnAjuste.Enabled = habilitado;
        }

        private bool AbrirRegistro(TipoMovimiento tipo)
        {
            using var scope = _scopeFactory.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<RegistrarMovimientoForm>();
            form.Tipo = tipo;
            return form.ShowDialog(this) == DialogResult.OK;
        }

        private async void btnEntrada_Click(object sender, EventArgs e)
        {
            if (AbrirRegistro(TipoMovimiento.Entrada))
                await CargarMovimientosAsync();
        }

        private async void btnSalida_Click(object sender, EventArgs e)
        {
            if (AbrirRegistro(TipoMovimiento.Salida))
                await CargarMovimientosAsync();
        }

        private async void btnAjuste_Click(object sender, EventArgs e)
        {
            if (AbrirRegistro(TipoMovimiento.Ajuste))
                await CargarMovimientosAsync();
        }

        private async void btnBuscar_Click(object sender, EventArgs e) => await CargarMovimientosAsync();

        private async void btnRefrescar_Click(object sender, EventArgs e) => await CargarMovimientosAsync();

        private void chkFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpDesde.Enabled = chkFiltrarFecha.Checked;
            dtpHasta.Enabled = chkFiltrarFecha.Checked;
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
    }
}
