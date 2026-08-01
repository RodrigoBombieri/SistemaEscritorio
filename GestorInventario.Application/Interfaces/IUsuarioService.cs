using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestorInventario.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task<Usuario> GetByIdAsync(int id);
        Task<Usuario> AutenticarAsync(string nombreUsuario, string password);
        Task CrearUsuarioAsync(string nombreUsuario, string password, string nombreCompleto, RolUsuario rol);
        Task CambiarPasswordAsync(int usuarioId, string nuevaPassword);
        Task ActualizarAsync(Usuario usuario);
        Task<bool> ExisteUsuarioAsync(string nombreUsuario);
        Task DesactivarAsync(int id);
    }
}
