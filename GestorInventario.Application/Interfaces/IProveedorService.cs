using GestorInventario.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestorInventario.Application.Interfaces
{
    public interface IProveedorService
    {
        Task<IEnumerable<Proveedor>> GetAllAsync();
        Task<Proveedor> GetByIdAsync(int id);
        Task CrearAsync(Proveedor proveedor);
        Task ActualizarAsync(Proveedor proveedor);
        Task DesactivarAsync(int id);
    }
}
