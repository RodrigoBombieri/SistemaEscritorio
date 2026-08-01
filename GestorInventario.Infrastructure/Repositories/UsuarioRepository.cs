using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Interfaces;
using GestorInventario.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GestorInventario.Infrastructure.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AppDbContext context) : base(context) { }

        public async Task<Usuario> GetByNombreUsuarioAsync(string nombreUsuario)
        {
            return (await _dbSet.FirstOrDefaultAsync(u => u.NombreUsuario == nombreUsuario))!;
        }
    }
}
