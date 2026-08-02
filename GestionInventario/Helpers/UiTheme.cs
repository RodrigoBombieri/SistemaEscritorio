using System.Drawing;

namespace GestionInventario.Helpers
{
    /// <summary>
    /// Paleta de colores y tipografías de toda la aplicación.
    /// Para cambiar el estilo visual del sistema, modificar únicamente esta clase:
    /// todos los formularios se estilizan a través de <see cref="UiStyler"/>, que lee estos valores.
    /// </summary>
    public static class UiTheme
    {
        // ---- Colores principales (barra superior / menú lateral de MainForm) ----
        public static readonly Color PrimarioOscuro = ColorTranslator.FromHtml("#073F32");
        public static readonly Color PrimarioMasOscuro = ColorTranslator.FromHtml("#0B4C3D");
        public static readonly Color PrimarioSeleccionado = ColorTranslator.FromHtml("#DFF3EA");
        public static readonly Color PrimarioHover = ColorTranslator.FromHtml("#14604D");
        public static readonly Color PrimarioTextoSuave = ColorTranslator.FromHtml("#8FD2B8");

        // ---- Fondos ----
        public static readonly Color FondoContenido = ColorTranslator.FromHtml("#F4F2EC");
        public static readonly Color FondoSuperficie = Color.White;
        public static readonly Color FondoFilaAlterna = ColorTranslator.FromHtml("#FAF9F6");

        // ---- Texto ----
        public static readonly Color TextoPrimario = ColorTranslator.FromHtml("#2C2C2A");
        public static readonly Color TextoSecundario = ColorTranslator.FromHtml("#5F5E5A");
        public static readonly Color TextoSobrePrimario = ColorTranslator.FromHtml("#DFF3EA");

        // ---- Bordes ----
        public static readonly Color Borde = ColorTranslator.FromHtml("#D3D1C7");

        // ---- Estados (para usar en celdas de grilla: stock bajo / inactivo / normal) ----
        public static readonly Color EstadoNormalFondo = ColorTranslator.FromHtml("#EAF3DE");
        public static readonly Color EstadoNormalTexto = ColorTranslator.FromHtml("#3B6D11");
        public static readonly Color EstadoAlertaFondo = ColorTranslator.FromHtml("#FAECE7");
        public static readonly Color EstadoAlertaTexto = ColorTranslator.FromHtml("#993C1D");
        public static readonly Color EstadoInactivoFondo = ColorTranslator.FromHtml("#F1EFE8");
        public static readonly Color EstadoInactivoTexto = ColorTranslator.FromHtml("#5F5E5A");

        // ---- Botones ----
        public static readonly Color BotonPrimarioFondo = ColorTranslator.FromHtml("#0F6E56");
        public static readonly Color BotonPrimarioFondoHover = ColorTranslator.FromHtml("#0B5744");
        public static readonly Color BotonPrimarioTexto = Color.White;
        public static readonly Color BotonSecundarioBorde = ColorTranslator.FromHtml("#B4B2A9");
        public static readonly Color BotonSecundarioTexto = ColorTranslator.FromHtml("#2C2C2A");
        public static readonly Color BotonSecundarioFondoHover = ColorTranslator.FromHtml("#F1EFE8");
        public static readonly Color BotonPeligroBorde = ColorTranslator.FromHtml("#E24B4A");
        public static readonly Color BotonPeligroTexto = ColorTranslator.FromHtml("#A32D2D");
        public static readonly Color BotonPeligroFondoHover = ColorTranslator.FromHtml("#FCEBEB");

        // ---- Tipografías ----
        public static readonly Font FuenteBase = new("Segoe UI", 9F);
        public static readonly Font FuenteTitulo = new("Segoe UI", 11F, FontStyle.Bold);
        public static readonly Font FuenteEncabezadoGrilla = new("Segoe UI", 9F, FontStyle.Bold);

        // ---- Íconos de botones (fuente de íconos del sistema, ver UiStyler) ----
        public static readonly string FuenteIconos = "Segoe MDL2 Assets";
        public const int TamanoIcono = 13;
        public const int AnchoBotonMenu = 160;

        // ---- Tamaño mínimo de botón, para que el ícono + texto entren sin recortarse ----
        public const int AltoBoton = 32;
        public const int AnchoExtraBoton = 8;
    }
}
