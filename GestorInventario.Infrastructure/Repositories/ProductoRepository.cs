using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Interfaces;
using GestorInventario.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorInventario.Infrastructure.Repositories
{
    public class ProductoRepository : RepositoryBase<Producto>, IProductoRepository
    {
        public ProductoRepository(AppDbContext context) : base(context) { }

        public override async Task<Producto> GetByIdAsync(int id)
        {
            return (await _dbSet
                .Include(p => p.Categoria)
                .Include(p => p.Proveedor)
                .FirstOrDefaultAsync(p => p.Id == id))!;
        }

        public override async Task<IEnumerable<Producto>> GetAllAsync()
        {
            return await _dbSet
                .Include(p => p.Categoria)
                .Include(p => p.Proveedor)
                .ToListAsync();
        }

        public async Task<Producto> GetByCodigoAsync(string codigo)
        {
            return (await _dbSet
                .Include(p => p.Categoria)
                .Include(p => p.Proveedor)
                .FirstOrDefaultAsync(p => p.Codigo == codigo))!;
        }

        public async Task<IEnumerable<Producto>> GetConStockBajoAsync()
        {
            return await _dbSet
                .Include(p => p.Categoria)
                .Include(p => p.Proveedor)
                .Where(p => p.Activo && p.StockActual <= p.StockMinimo)
                .ToListAsync();
        }

        public async Task<IEnumerable<Producto>> GetByCategoriaAsync(int categoriaId)
        {
            return await _dbSet
                .Include(p => p.Categoria)
                .Include(p => p.Proveedor)
                .Where(p => p.CategoriaId == categoriaId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Producto>> GetByProveedorAsync(int proveedorId)
        {
            return await _dbSet
                .Include(p => p.Categoria)
                .Where(p => p.ProveedorId == proveedorId)
                .ToListAsync();
        }
    }
}
