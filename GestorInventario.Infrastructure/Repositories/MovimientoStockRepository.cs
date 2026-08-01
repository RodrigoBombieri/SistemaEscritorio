using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Interfaces;
using GestorInventario.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorInventario.Infrastructure.Repositories
{
    public class MovimientoStockRepository : RepositoryBase<MovimientoStock>, IMovimientoStockRepository
    {
        public MovimientoStockRepository(AppDbContext context) : base(context) { }

        public override async Task<IEnumerable<MovimientoStock>> GetAllAsync()
        {
            return await _dbSet
                .Include(m => m.Producto)
                .Include(m => m.Usuario)
                .OrderByDescending(m => m.Fecha)
                .ToListAsync();
        }

        public async Task<IEnumerable<MovimientoStock>> GetByProductoAsync(int productoId)
        {
            return await _dbSet
                .Include(m => m.Usuario)
                .Where(m => m.ProductoId == productoId)
                .OrderByDescending(m => m.Fecha)
                .ToListAsync();
        }

        public async Task<IEnumerable<MovimientoStock>> GetByFechaAsync(DateTime desde, DateTime hasta)
        {
            return await _dbSet
                .Include(m => m.Producto)
                .Include(m => m.Usuario)
                .Where(m => m.Fecha >= desde && m.Fecha <= hasta)
                .OrderByDescending(m => m.Fecha)
                .ToListAsync();
        }
    }
}
