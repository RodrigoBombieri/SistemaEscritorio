using GestorInventario.Application.Interfaces;
using GestorInventario.Domain.Entities;
using GestorInventario.Domain.Enums;
using GestorInventario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestorInventario.Application.Services
{
    public class StockService : IStockService
    {
        private readonly IProductoRepository _productoRepository;
        private readonly IMovimientoStockRepository _movimientoRepository;

        public StockService(IProductoRepository productoRepository, IMovimientoStockRepository movimientoRepository)
        {
            _productoRepository = productoRepository;
            _movimientoRepository = movimientoRepository;
        }

        public Task<IEnumerable<MovimientoStock>> GetAllAsync() => _movimientoRepository.GetAllAsync();

        public Task<IEnumerable<MovimientoStock>> GetByProductoAsync(int productoId) => _movimientoRepository.GetByProductoAsync(productoId);

        public Task<IEnumerable<MovimientoStock>> GetByFechaAsync(DateTime desde, DateTime hasta) => _movimientoRepository.GetByFechaAsync(desde, hasta);

        public async Task RegistrarEntradaAsync(int productoId, int cantidad, string motivo, int usuarioId)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero.");

            var producto = await ObtenerProductoOFallarAsync(productoId);

            producto.StockActual += cantidad;

            await GuardarMovimientoAsync(producto, TipoMovimiento.Entrada, cantidad, motivo, usuarioId);
        }

        public async Task RegistrarSalidaAsync(int productoId, int cantidad, string motivo, int usuarioId)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero.");

            var producto = await ObtenerProductoOFallarAsync(productoId);

            if (producto.StockActual < cantidad)
                throw new InvalidOperationException(
                    $"Stock insuficiente. Stock actual: {producto.StockActual}, solicitado: {cantidad}.");

            producto.StockActual -= cantidad;

            await GuardarMovimientoAsync(producto, TipoMovimiento.Salida, cantidad, motivo, usuarioId);
        }

        public async Task RegistrarAjusteAsync(int productoId, int nuevoStock, string motivo, int usuarioId)
        {
            if (nuevoStock < 0)
                throw new ArgumentException("El stock no puede ser negativo.");

            var producto = await ObtenerProductoOFallarAsync(productoId);

            var diferencia = Math.Abs(nuevoStock - producto.StockActual);
            producto.StockActual = nuevoStock;

            await GuardarMovimientoAsync(producto, TipoMovimiento.Ajuste, diferencia, motivo, usuarioId);
        }

        private async Task<Producto> ObtenerProductoOFallarAsync(int productoId)
        {
            var producto = await _productoRepository.GetByIdAsync(productoId);
            if (producto == null)
                throw new KeyNotFoundException($"No se encontró el producto con id {productoId}.");

            return producto;
        }

        private async Task GuardarMovimientoAsync(Producto producto, TipoMovimiento tipo, int cantidad, string motivo, int usuarioId)
        {
            var movimiento = new MovimientoStock
            {
                ProductoId = producto.Id,
                Tipo = tipo,
                Cantidad = cantidad,
                Motivo = motivo,
                UsuarioId = usuarioId,
                Fecha = DateTime.Now
            };

            _productoRepository.Update(producto);
            await _movimientoRepository.AddAsync(movimiento);

            // Producto y MovimientoStock comparten el mismo AppDbContext (mismo scope de DI),
            // así que un solo SaveChanges persiste ambas operaciones juntas.
            await _movimientoRepository.SaveChangesAsync();
        }
    }
}
