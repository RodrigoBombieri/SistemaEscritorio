using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Domain.Enums
{
    public enum TipoMovimiento
    {
        Entrada = 1,
        Salida = 2,
        Ajuste = 3
    }

    public enum RolUsuario
    {
        Administrador = 1,
        Empleado = 2
    }
}
