using GestionInventario.Forms.Categorias;
using GestionInventario.Forms.Movimientos;
using GestionInventario.Forms.Productos;
using GestionInventario.Forms.Proveedores;
using GestionInventario.Forms.Usuarios;
using GestionInventario.Helpers;
using GestorInventario.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace GestionInventario
{
    public partial class MainForm : Form
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public MainForm(IServiceScopeFactory scopeFactory)
        {
            InitializeComponent();
            UiStyler.EstilizarVentanaPrincipal(this);
            _scopeFactory = scopeFactory;
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var usuario = SesionActual.UsuarioActual;
            lblUsuario.Text = $"{usuario.NombreCompleto} · {usuario.Rol}";
            tsslUsuario.Text = $"Conectado como {usuario.NombreCompleto} ({usuario.Rol})";

            btnUsuarios.Visible = usuario.Rol == RolUsuario.Administrador;
        }

        private void btnProductos_Click(object sender, EventArgs e)
            => AbrirFormularioHijo<ProductosForm>();

        private void btnCategorias_Click(object sender, EventArgs e)
            => AbrirFormularioHijo<CategoriasForm>();

        private void btnProveedores_Click(object sender, EventArgs e)
            => AbrirFormularioHijo<ProveedoresForm>();

        private void btnMovimientos_Click(object sender, EventArgs e)
            => AbrirFormularioHijo<MovimientosForm>();

        private void btnUsuarios_Click(object sender, EventArgs e)
            => AbrirFormularioHijo<UsuariosForm>();

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            SesionActual.CerrarSesion();
            Application.Restart();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void AbrirFormularioHijo<TForm>() where TForm : Form
        {
            var scope = _scopeFactory.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<TForm>();

            form.MdiParent = this;
            form.FormClosed += (s, e) => scope.Dispose();
            form.Show();
        }
    }
}