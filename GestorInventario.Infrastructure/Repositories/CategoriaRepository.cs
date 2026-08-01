using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Interfaces;
using GestorInventario.Infrastructure.Data;

namespace GestorInventario.Infrastructure.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext context) : base(context) { }
    }
}
