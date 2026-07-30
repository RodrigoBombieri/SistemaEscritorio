using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }          // código interno o de barras
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int? ProveedorId { get; set; }        // nullable: no todos los productos necesitan uno
        public Proveedor Proveedor { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }

        public int StockActual { get; set; }         // se actualiza con cada movimiento
        public int StockMinimo { get; set; }          // para alertas de reposición

        public bool Activo { get; set; } = true;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        public ICollection<MovimientoStock> Movimientos { get; set; }
    }
}