using GestorInventario.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Domain.Entities
{
    public class MovimientoStock
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public TipoMovimiento Tipo { get; set; }     // Entrada, Salida, Ajuste
        public int Cantidad { get; set; }
        public string Motivo { get; set; }            // "Compra", "Venta", "Merma", "Ajuste inventario", etc.

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}