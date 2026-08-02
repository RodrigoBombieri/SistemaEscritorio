using GestionInventario.Forms.Categorias;
using GestionInventario.Forms.Login;
using GestionInventario.Forms.Productos;
using GestorInventario.Application.Interfaces;
using GestorInventario.Application.Services;
using GestorInventario.Domain.Interfaces;
using GestorInventario.Infrastructure.Data;
using GestorInventario.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace GestionInventario
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
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
    }
}