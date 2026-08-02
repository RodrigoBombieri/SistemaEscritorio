using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario.Forms.Categorias
{
    public partial class CategoriasForm : Form
    {
        private readonly ICategoriaService _categoriaService;
        private readonly IServiceScopeFactory _scopeFactory;
        private bool _cargando;

        public CategoriasForm(ICategoriaService categoriaService, IServiceScopeFactory scopeFactory)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _scopeFactory = scopeFactory;
            Load += CategoriasForm_Load;
        }

        private async void CategoriasForm_Load(object sender, EventArgs e) => await CargarCategoriasAsync();

        private async Task CargarCategoriasAsync()
        {
            if (_cargando) return;
            _cargando = true;
            SetControlesHabilitados(false);
            try
            {
                var categorias = (await _categoriaService.GetAllAsync()).AsEnumerable();

                var texto = txtBuscar.Text.Trim();
                if (!string.IsNullOrWhiteSpace(texto))
                {
                    categorias = categorias.Where(c => c.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase));
                }

                dgvCategorias.Rows.Clear();
                foreach (var c in categorias.OrderBy(c => c.Nombre))
                {
                    var idx = dgvCategorias.Rows.Add(c.Nombre, c.Descripcion);
                    dgvCategorias.Rows[idx].Tag = c;
                }
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
            btnEliminar.Enabled = habilitado;
        }

        private Categoria ObtenerCategoriaSeleccionada()
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una categoría de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return (Categoria)dgvCategorias.CurrentRow.Tag;
        }

        private bool AbrirFormularioEdicion(int? categoriaId)
        {
            using var scope = _scopeFactory.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<CategoriaEditForm>();
            form.CategoriaId = categoriaId;
            return form.ShowDialog(this) == DialogResult.OK;
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            if (AbrirFormularioEdicion(null))
                await CargarCategoriasAsync();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var categoria = ObtenerCategoriaSeleccionada();
            if (categoria == null) return;

            if (AbrirFormularioEdicion(categoria.Id))
                await CargarCategoriasAsync();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var categoria = ObtenerCategoriaSeleccionada();
            if (categoria == null) return;

            var confirmar = MessageBox.Show(
                $"¿Eliminar la categoría '{categoria.Nombre}'?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar != DialogResult.Yes) return;

            try
            {
                await _categoriaService.EliminarAsync(categoria.Id);
                await CargarCategoriasAsync();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e) => await CargarCategoriasAsync();

        private async void btnRefrescar_Click(object sender, EventArgs e) => await CargarCategoriasAsync();

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
    }
}
