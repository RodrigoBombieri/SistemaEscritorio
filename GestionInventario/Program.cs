using System;
using System.Configuration;
using System.Windows.Forms;
using GestorInventario.Domain.Interfaces;
using GestorInventario.Infrastructure.Data;
using GestorInventario.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
            // Formularios
            services.AddScoped<Form1>();

            using var provider = services.BuildServiceProvider();
            using var scope = provider.CreateScope();

            var mainForm = scope.ServiceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }
    }
}