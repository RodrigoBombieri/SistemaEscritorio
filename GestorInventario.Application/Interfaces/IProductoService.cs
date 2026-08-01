using GestorInventario.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestorInventario.Application.Interfaces
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetAllAsync();
        Task<Producto> GetByIdAsync(int id);
        Task<Producto> GetByCodigoAsync(string codigo);
        Task<IEnumerable<Producto>> GetConStockBajoAsync();
        Task<IEnumerable<Producto>> GetByCategoriaAsync(int categoriaId);
        Task<IEnumerable<Producto>> GetByProveedorAsync(int proveedorId);
        Task CrearAsync(Producto producto);
        Task ActualizarAsync(Producto producto);
        Task DesactivarAsync(int id);
    }
}
