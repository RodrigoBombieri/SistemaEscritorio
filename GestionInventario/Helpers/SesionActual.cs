using GestorInventario.Domain.Entities;

namespace GestionInventario.Helpers
{
    public static class SesionActual
    {
        public static Usuario UsuarioActual { get; set; }

        public static bool EstaLogueado => UsuarioActual != null;

        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
    }
}