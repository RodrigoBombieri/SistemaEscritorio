using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorInventario.Domain.Entities;

namespace GestorInventario.Domain.Interfaces
{
    public interface IMovimientoStockRepository : IRepository<MovimientoStock>
    {
        Task<IEnumerable<MovimientoStock>> GetByProductoAsync(int productoId);
        Task<IEnumerable<MovimientoStock>> GetByFechaAsync(DateTime desde, DateTime hasta);
    }
}