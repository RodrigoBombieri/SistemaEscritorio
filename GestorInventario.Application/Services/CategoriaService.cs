using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestorInventario.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IProductoRepository _productoRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository, IProductoRepository productoRepository)
        {
            _categoriaRepository = categoriaRepository;
            _productoRepository = productoRepository;
        }

        public Task<IEnumerable<Categoria>> GetAllAsync() => _categoriaRepository.GetAllAsync();

        public Task<Categoria> GetByIdAsync(int id) => _categoriaRepository.GetByIdAsync(id);

        public async Task CrearAsync(Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                throw new ArgumentException("El nombre de la categoría es obligatorio.");

            await _categoriaRepository.AddAsync(categoria);
            await _categoriaRepository.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Categoria categoria)
        {
            _categoriaRepository.Update(categoria);
            await _categoriaRepository.SaveChangesAsync();
        }

        public async Task EliminarAsync(int id)
        {
            var categoria = await _categoriaRepository.GetByIdAsync(id);
            if (categoria == null)
                throw new KeyNotFoundException($"No se encontró la categoría con id {id}.");

            var productosAsociados = await _productoRepository.GetByCategoriaAsync(id);
            if (productosAsociados.Any())
                throw new InvalidOperationException("No se puede eliminar la categoría: tiene productos asociados.");

            _categoriaRepository.Remove(categoria);
            await _categoriaRepository.SaveChangesAsync();
        }
    }
}
