using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestorInventario.Application.Services
{
    public class ProveedorService : IProveedorService
    {
        private readonly IProveedorRepository _proveedorRepository;

        public ProveedorService(IProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }

        public Task<IEnumerable<Proveedor>> GetAllAsync() => _proveedorRepository.GetAllAsync();

        public Task<Proveedor> GetByIdAsync(int id) => _proveedorRepository.GetByIdAsync(id);

        public async Task CrearAsync(Proveedor proveedor)
        {
            if (string.IsNullOrWhiteSpace(proveedor.RazonSocial))
                throw new ArgumentException("La razón social del proveedor es obligatoria.");

            proveedor.Activo = true;
            await _proveedorRepository.AddAsync(proveedor);
            await _proveedorRepository.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Proveedor proveedor)
        {
            _proveedorRepository.Update(proveedor);
            await _proveedorRepository.SaveChangesAsync();
        }

        public async Task DesactivarAsync(int id)
        {
            var proveedor = await _proveedorRepository.GetByIdAsync(id);
            if (proveedor == null)
                throw new KeyNotFoundException($"No se encontró el proveedor con id {id}.");

            proveedor.Activo = false;
            _proveedorRepository.Update(proveedor);
            await _proveedorRepository.SaveChangesAsync();
        }
    }
}
