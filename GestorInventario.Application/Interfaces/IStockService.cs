using GestorInventario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestorInventario.Application.Interfaces
{
    public interface IStockService
    {
        Task<IEnumerable<MovimientoStock>> GetAllAsync();
        Task<IEnumerable<MovimientoStock>> GetByProductoAsync(int productoId);
        Task<IEnumerable<MovimientoStock>> GetByFechaAsync(DateTime desde, DateTime hasta);
        Task RegistrarEntradaAsync(int productoId, int cantidad, string motivo, int usuarioId);
        Task RegistrarSalidaAsync(int productoId, int cantidad, string motivo, int usuarioId);
        Task RegistrarAjusteAsync(int productoId, int nuevoStock, string motivo, int usuarioId);
    }
}
