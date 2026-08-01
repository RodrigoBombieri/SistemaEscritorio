using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Interfaces;
using GestorInventario.Infrastructure.Data;

namespace GestorInventario.Infrastructure.Repositories
{
    public class ProveedorRepository : RepositoryBase<Proveedor>, IProveedorRepository
    {
        public ProveedorRepository(AppDbContext context) : base(context) { }
    }
}
