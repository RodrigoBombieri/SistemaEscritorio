using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario
{
    public partial class Form1 : Form
    {
        private readonly ICategoriaService _categoriaService;
        private readonly IProductoService _productoService;
        private readonly IStockService _stockService;
        private readonly IUsuarioService _usuarioService;

        public Form1(ICategoriaService categoriaService, IProductoService productoService,
                     IStockService stockService, IUsuarioService usuarioService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _productoService = productoService;
            _stockService = stockService;
            _usuarioService = usuarioService;

            Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // usuario para probar login/movimientos
                if (!await _usuarioService.ExisteUsuarioAsync("admin"))
                {
                    await _usuarioService.CrearUsuarioAsync("admin", "1234", "Administrador", RolUsuario.Administrador);
                }
                var usuario = await _usuarioService.AutenticarAsync("admin", "1234");

                var categoria = new Categoria { Nombre = "Bebidas", Descripcion = "Prueba" };
                await _categoriaService.CrearAsync(categoria);

                var producto = new Producto
                {
                    Codigo = "TEST001",
                    Nombre = "Producto de prueba",
                    Descripcion = "Producto creado para probar la capa de servicios",
                    CategoriaId = categoria.Id,
                    PrecioCosto = 100,
                    PrecioVenta = 150,
                    StockMinimo = 5
                };
                await _productoService.CrearAsync(producto);

                await _stockService.RegistrarEntradaAsync(producto.Id, 20, "Carga inicial", usuario.Id);

                var actualizado = await _productoService.GetByIdAsync(producto.Id);

                MessageBox.Show($"Login: {(usuario != null ? "OK" : "FALLÓ")}\nStock actual: {actualizado.StockActual}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n\nInner: {ex.InnerException?.Message}");
            }
        }
    }
}
