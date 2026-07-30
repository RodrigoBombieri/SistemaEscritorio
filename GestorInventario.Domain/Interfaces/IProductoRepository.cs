using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorInventario.Domain.Entities;

namespace GestorInventario.Domain.Interfaces
{
    public interface IProductoRepository : IRepository<Producto>
    {
        Task<Producto> GetByCodigoAsync(string codigo);
        Task<IEnumerable<Producto>> GetConStockBajoAsync();
        Task<IEnumerable<Producto>> GetByCategoriaAsync(int categoriaId);
        Task<IEnumerable<Producto>> GetByProveedorAsync(int proveedorId);
    }
}