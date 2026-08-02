using GestionInventario.Forms.Categorias;
using GestionInventario.Forms.Login;
using GestionInventario.Forms.Movimientos;
using GestionInventario.Forms.Productos;
using GestionInventario.Forms.Proveedores;
using GestionInventario.Forms.Usuarios;
using GestorInventario.Application.Interfaces;
using GestorInventario.Application.Services;
using GestorInventario.Domain.Interfaces;
using GestorInventario.Infrastructure.Data;
using GestorInventario.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace GestionInventario
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Manejo global de excepciones no controladas: en vez de que la app se cierre
            // de golpe (o muestre la pantalla fea de .NET), se loguea a disco y se avisa
            // con un mensaje entendible. Tiene que registrarse antes de EnableVisualStyles/Run.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, e) => RegistrarYMostrarError(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, e) => RegistrarYMostrarError(e.ExceptionObject as Exception);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            var services = new ServiceCollection();
            // Contexto de base de datos
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));
            // Repositorios
            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProveedorRepository, ProveedorRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IMovimientoStockRepository, MovimientoStockRepository>();

            // Servicios
            services.AddScoped<IProductoService, ProductoService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IProveedorService, ProveedorService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IStockService, StockService>();


            // Formularios
            services.AddSingleton<MainForm>();
            services.AddScoped<LoginForm>();
            services.AddScoped<ProductosForm>();
            services.AddScoped<ProductoEditForm>();
            services.AddScoped<CategoriasForm>();
            services.AddScoped<CategoriaEditForm>();
            services.AddScoped<ProveedoresForm>();
            services.AddScoped<ProveedorEditForm>();
            services.AddScoped<UsuariosForm>();
            services.AddScoped<UsuarioEditForm>();
            services.AddScoped<CambiarPasswordForm>();
            services.AddScoped<MovimientosForm>();
            services.AddScoped<RegistrarMovimientoForm>();

            using var provider = services.BuildServiceProvider();
            // Mostrar el formulario de inicio de sesión antes de abrir el formulario principal
            using (var loginScope = provider.CreateScope())
            {
                var loginForm = loginScope.ServiceProvider.GetRequiredService<LoginForm>();
                if (loginForm.ShowDialog() != DialogResult.OK)
                    return;
            }
            // Abrir el formulario principal después de un inicio de sesión exitoso
            var mainForm = provider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }

        private static void RegistrarYMostrarError(Exception ex)
        {
            try
            {
                var carpetaLogs = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
                Directory.CreateDirectory(carpetaLogs);

                var archivo = Path.Combine(carpetaLogs, $"errores_{DateTime.Now:yyyyMMdd}.log");
                File.AppendAllText(archivo, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {ex}{Environment.NewLine}{Environment.NewLine}");
            }
            catch
            {
                // Si ni siquiera se puede escribir el log, no hay mucho más para hacer acá;
                // igual le mostramos el error al usuario más abajo.
            }

            MessageBox.Show(
                $"Ocurrió un error inesperado y fue registrado en la carpeta Logs.\n\nDetalle: {ex?.Message}",
                "Error inesperado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}