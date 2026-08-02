using GestionInventario.Helpers;
using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace GestionInventario.Forms.Categorias
{
    public partial class CategoriaEditForm : Form
    {
        private readonly ICategoriaService _categoriaService;
        private Categoria _categoria;

        public int? CategoriaId { get; set; }

        public CategoriaEditForm(ICategoriaService categoriaService)
        {
            InitializeComponent();
            UiStyler.EstilizarFormularioModal(this);
            _categoriaService = categoriaService;
            Load += CategoriaEditForm_Load;
        }

        private async void CategoriaEditForm_Load(object sender, EventArgs e)
        {
            Text = CategoriaId.HasValue ? "Editar Categoría" : "Nueva Categoría";

            if (CategoriaId.HasValue)
            {
                _categoria = await _categoriaService.GetByIdAsync(CategoriaId.Value);
                if (_categoria == null)
                {
                    MessageBox.Show("La categoría no existe o fue eliminada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                txtNombre.Text = _categoria.Nombre;
                txtDescripcion.Text = _categoria.Descripcion;
            }
            else
            {
                _categoria = new Categoria();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MostrarError("El nombre es obligatorio.");
                return;
            }

            _categoria.Nombre = txtNombre.Text.Trim();
            _categoria.Descripcion = txtDescripcion.Text.Trim();

            btnGuardar.Enabled = false;
            try
            {
                if (CategoriaId.HasValue)
                    await _categoriaService.ActualizarAsync(_categoria);
                else
                    await _categoriaService.CrearAsync(_categoria);

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