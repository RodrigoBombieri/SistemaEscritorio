using GestorInventario.Application.Interfaces;
using GestorInventario.Application.Security;
using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Enums;
using GestorInventario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestorInventario.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<IEnumerable<Usuario>> GetAllAsync() => _usuarioRepository.GetAllAsync();

        public Task<Usuario> GetByIdAsync(int id) => _usuarioRepository.GetByIdAsync(id);

        public async Task<Usuario> AutenticarAsync(string nombreUsuario, string password)
        {
            var usuario = await _usuarioRepository.GetByNombreUsuarioAsync(nombreUsuario);
            if (usuario == null || !usuario.Activo)
                return null;

            return PasswordHasher.Verify(password, usuario.PasswordHash) ? usuario : null;
        }

        public async Task CrearUsuarioAsync(string nombreUsuario, string password, string nombreCompleto, RolUsuario rol)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ArgumentException("El nombre de usuario es obligatorio.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("La contraseña es obligatoria.");

            var existente = await _usuarioRepository.GetByNombreUsuarioAsync(nombreUsuario);
            if (existente != null)
                throw new InvalidOperationException($"Ya existe un usuario con el nombre '{nombreUsuario}'.");

            var usuario = new Usuario
            {
                NombreUsuario = nombreUsuario,
                PasswordHash = PasswordHasher.Hash(password),
                NombreCompleto = nombreCompleto,
                Rol = rol,
                Activo = true
            };

            await _usuarioRepository.AddAsync(usuario);
            await _usuarioRepository.SaveChangesAsync();
        }

        public async Task CambiarPasswordAsync(int usuarioId, string nuevaPassword)
        {
            if (string.IsNullOrWhiteSpace(nuevaPassword))
                throw new ArgumentException("La contraseña es obligatoria.");

            var usuario = await _usuarioRepository.GetByIdAsync(usuarioId);
            if (usuario == null)
                throw new KeyNotFoundException($"No se encontró el usuario con id {usuarioId}.");

            usuario.PasswordHash = PasswordHasher.Hash(nuevaPassword);
            _usuarioRepository.Update(usuario);
            await _usuarioRepository.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
            await _usuarioRepository.SaveChangesAsync();
        }

        public async Task<bool> ExisteUsuarioAsync(string nombreUsuario)
        {
            var usuario = await _usuarioRepository.GetByNombreUsuarioAsync(nombreUsuario);
            return usuario != null;
        }

        public async Task DesactivarAsync(int id)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(id);
            if (usuario == null)
                throw new KeyNotFoundException($"No se encontró el usuario con id {id}.");

            usuario.Activo = false;
            _usuarioRepository.Update(usuario);
            await _usuarioRepository.SaveChangesAsync();
        }
    }
}
