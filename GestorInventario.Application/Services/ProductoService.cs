using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestorInventario.Application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public Task<IEnumerable<Producto>> GetAllAsync() => _productoRepository.GetAllAsync();

        public Task<Producto> GetByIdAsync(int id) => _productoRepository.GetByIdAsync(id);

        public Task<Producto> GetByCodigoAsync(string codigo) => _productoRepository.GetByCodigoAsync(codigo);

        public Task<IEnumerable<Producto>> GetConStockBajoAsync() => _productoRepository.GetConStockBajoAsync();

        public Task<IEnumerable<Producto>> GetByCategoriaAsync(int categoriaId) => _productoRepository.GetByCategoriaAsync(categoriaId);

        public Task<IEnumerable<Producto>> GetByProveedorAsync(int proveedorId) => _productoRepository.GetByProveedorAsync(proveedorId);

        public async Task CrearAsync(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new ArgumentException("El nombre del producto es obligatorio.");

            if (string.IsNullOrWhiteSpace(producto.Codigo))
                throw new ArgumentException("El código del producto es obligatorio.");

            var existente = await _productoRepository.GetByCodigoAsync(producto.Codigo);
            if (existente != null)
                throw new InvalidOperationException($"Ya existe un producto con el código '{producto.Codigo}'.");

            producto.FechaCreacion = DateTime.Now;
            producto.Activo = true;

            await _productoRepository.AddAsync(producto);
            await _productoRepository.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Producto producto)
        {
            var existente = await _productoRepository.GetByCodigoAsync(producto.Codigo);
            if (existente != null && existente.Id != producto.Id)
                throw new InvalidOperationException($"Ya existe otro producto con el código '{producto.Codigo}'.");

            _productoRepository.Update(producto);
            await _productoRepository.SaveChangesAsync();
        }

        public async Task DesactivarAsync(int id)
        {
            var producto = await _productoRepository.GetByIdAsync(id);
            if (producto == null)
                throw new KeyNotFoundException($"No se encontró el producto con id {id}.");

            producto.Activo = false;
            _productoRepository.Update(producto);
            await _productoRepository.SaveChangesAsync();
        }
    }
}
