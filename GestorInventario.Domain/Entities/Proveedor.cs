using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Domain.Entities
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }              // o "Documento" si querés algo más genérico
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

        public bool Activo { get; set; } = true;

        public ICollection<Producto> Productos { get; set; }
    }
}