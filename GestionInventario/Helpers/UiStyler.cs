using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GestionInventario.Helpers
{
    /// <summary>
    /// Aplica la paleta definida en <see cref="UiTheme"/> a los controles de un formulario,
    /// por convención de nombre (panelTop, panelBottom, btnNuevo, btnDesactivar, etc.).
    /// Los formularios llaman a uno de estos métodos una sola vez, después de InitializeComponent();
    /// no hace falta tocar ningún .Designer.cs para cambiar el look and feel de la aplicación.
    /// </summary>
    public static class UiStyler
    {
        /// <summary>Ventana principal (MDI): barra superior + menú lateral oscuros.</summary>
        public static void EstilizarVentanaPrincipal(Form form)
        {
            form.Font = UiTheme.FuenteBase;
            form.BackColor = UiTheme.FondoContenido;

            foreach (var control in TodosLosControles(form))
            {
                switch (control)
                {
                    case Panel panel when panel.Name == "panelTop":
                        panel.BackColor = UiTheme.PrimarioOscuro;
                        break;

                    case Panel panel when panel.Name == "panelMenu":
                        panel.BackColor = UiTheme.PrimarioMasOscuro;
                        break;

                    case Panel panel when EstaDentroDe(panel, "panelMenu"):
                        // Paneles/FlowLayoutPanel anidados dentro del menú (ej. flowMenu):
                        // deben heredar el mismo fondo oscuro, si no queda un rectángulo gris.
                        panel.BackColor = UiTheme.PrimarioMasOscuro;
                        break;

                    case Label lbl when lbl.Name == "lblTitulo":
                        lbl.Font = UiTheme.FuenteTitulo;
                        lbl.ForeColor = UiTheme.TextoSobrePrimario;
                        break;

                    case Label lbl when EstaDentroDe(lbl, "panelTop"):
                        lbl.ForeColor = UiTheme.PrimarioTextoSuave;
                        break;

                    case Button btn when EstaDentroDe(btn, "panelTop"):
                        EstilizarBotonContornoSobreOscuro(btn);
                        break;

                    case Button btn when EstaDentroDe(btn, "panelMenu"):
                        EstilizarBotonMenu(btn);
                        break;

                    case StatusStrip statusStrip:
                        statusStrip.BackColor = UiTheme.FondoSuperficie;
                        foreach (ToolStripItem item in statusStrip.Items)
                            item.ForeColor = UiTheme.TextoSecundario;
                        break;
                }
            }
        }

        /// <summary>Formularios de listado: barra de filtros + grilla + barra de acciones.</summary>
        public static void EstilizarFormularioListado(Form form)
        {
            form.Font = UiTheme.FuenteBase;
            form.BackColor = UiTheme.FondoContenido;

            foreach (var control in TodosLosControles(form))
            {
                switch (control)
                {
                    case Panel panel when panel.Name is "panelTop" or "panelBottom":
                        panel.BackColor = UiTheme.FondoSuperficie;
                        break;

                    case DataGridView grilla:
                        EstilizarGrilla(grilla);
                        break;

                    case Button boton:
                        EstilizarBotonPorNombre(boton);
                        break;

                    case Label etiqueta when etiqueta.Name == "lblTitulo":
                        etiqueta.Font = UiTheme.FuenteTitulo;
                        etiqueta.ForeColor = UiTheme.TextoPrimario;
                        break;

                    case Label etiqueta:
                        etiqueta.ForeColor = UiTheme.TextoSecundario;
                        break;
                }
            }
        }

        /// <summary>Formularios modales de alta/edición (login incluido).</summary>
        public static void EstilizarFormularioModal(Form form)
        {
            form.Font = UiTheme.FuenteBase;
            form.BackColor = UiTheme.FondoSuperficie;

            foreach (var control in TodosLosControles(form))
            {
                if (control is Button boton)
                    EstilizarBotonPorNombre(boton);
            }
        }

        // ---------------- Estilos de grilla ----------------

        private static void EstilizarGrilla(DataGridView grilla)
        {
            grilla.BackgroundColor = UiTheme.FondoSuperficie;
            grilla.BorderStyle = BorderStyle.None;
            grilla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grilla.GridColor = UiTheme.Borde;
            grilla.RowHeadersVisible = false;
            grilla.EnableHeadersVisualStyles = false;

            grilla.ColumnHeadersDefaultCellStyle.BackColor = UiTheme.PrimarioOscuro;
            grilla.ColumnHeadersDefaultCellStyle.ForeColor = UiTheme.TextoSobrePrimario;
            grilla.ColumnHeadersDefaultCellStyle.Font = UiTheme.FuenteEncabezadoGrilla;
            grilla.ColumnHeadersHeight = 34;
            grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            grilla.DefaultCellStyle.BackColor = UiTheme.FondoSuperficie;
            grilla.DefaultCellStyle.ForeColor = UiTheme.TextoPrimario;
            // Un tono distinto al del encabezado: si usáramos el mismo verde oscuro acá,
            // la fila que queda seleccionada por defecto al cargar los datos se ve idéntica al header.
            grilla.DefaultCellStyle.SelectionBackColor = UiTheme.PrimarioSeleccionado;
            grilla.DefaultCellStyle.SelectionForeColor = UiTheme.PrimarioOscuro;
            grilla.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);

            grilla.AlternatingRowsDefaultCellStyle.BackColor = UiTheme.FondoFilaAlterna;
            grilla.RowTemplate.Height = 30;
        }

        /// <summary>
        /// Colorea el texto de una fila de grilla según su estado (inactivo / con alerta),
        /// usando los mismos tonos que el resto de la aplicación en vez de colores sueltos.
        /// </summary>
        public static void ColorearFilaPorEstado(DataGridViewRow fila, bool activo, bool alerta = false)
        {
            if (!activo)
                fila.DefaultCellStyle.ForeColor = UiTheme.EstadoInactivoTexto;
            else if (alerta)
                fila.DefaultCellStyle.ForeColor = UiTheme.EstadoAlertaTexto;
        }

        // ---------------- Estilos de botón ----------------

        private static void EstilizarBotonPorNombre(Button boton)
        {
            var nombre = boton.Name.ToLowerInvariant();

            if (nombre.Contains("nuevo") || nombre.Contains("guardar") || nombre.Contains("ingresar"))
                EstilizarBotonPrimario(boton);
            else if (nombre.Contains("desactivar") || nombre.Contains("eliminar"))
                EstilizarBotonPeligro(boton);
            else
                EstilizarBotonSecundario(boton);
        }

        private static void EstilizarBotonPrimario(Button boton)
        {
            boton.UseVisualStyleBackColor = false;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatAppearance.MouseOverBackColor = UiTheme.BotonPrimarioFondoHover;
            boton.BackColor = UiTheme.BotonPrimarioFondo;
            boton.ForeColor = UiTheme.BotonPrimarioTexto;
            boton.Cursor = Cursors.Hand;
            AsegurarTamanoMinimo(boton);
            AsignarIcono(boton);
        }

        private static void EstilizarBotonSecundario(Button boton)
        {
            boton.UseVisualStyleBackColor = false;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.BorderColor = UiTheme.BotonSecundarioBorde;
            boton.FlatAppearance.MouseOverBackColor = UiTheme.BotonSecundarioFondoHover;
            boton.BackColor = UiTheme.FondoSuperficie;
            boton.ForeColor = UiTheme.BotonSecundarioTexto;
            boton.Cursor = Cursors.Hand;
            AsegurarTamanoMinimo(boton);
            AsignarIcono(boton);
        }

        private static void EstilizarBotonPeligro(Button boton)
        {
            boton.UseVisualStyleBackColor = false;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.BorderColor = UiTheme.BotonPeligroBorde;
            boton.FlatAppearance.MouseOverBackColor = UiTheme.BotonPeligroFondoHover;
            boton.BackColor = UiTheme.FondoSuperficie;
            boton.ForeColor = UiTheme.BotonPeligroTexto;
            boton.Cursor = Cursors.Hand;
            AsegurarTamanoMinimo(boton);
            AsignarIcono(boton);
        }

        private static void EstilizarBotonContornoSobreOscuro(Button boton)
        {
            boton.UseVisualStyleBackColor = false;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.BorderColor = UiTheme.PrimarioHover;
            boton.FlatAppearance.MouseOverBackColor = UiTheme.PrimarioHover;
            boton.BackColor = UiTheme.PrimarioOscuro;
            boton.ForeColor = UiTheme.TextoSobrePrimario;
            boton.Cursor = Cursors.Hand;

            // Este botón vive en la barra superior (44px de alto fijo): solo se ensancha,
            // no se agranda en alto para no quedar pegado contra el borde del panel.
            boton.Width += UiTheme.AnchoExtraBoton;

            AsignarIcono(boton);
        }

        private static void EstilizarBotonMenu(Button boton)
        {
            boton.UseVisualStyleBackColor = false;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatAppearance.MouseOverBackColor = UiTheme.PrimarioHover;
            boton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            boton.Cursor = Cursors.Hand;

            var esSalir = boton.Name.ToLowerInvariant().Contains("salir");
            boton.BackColor = UiTheme.PrimarioMasOscuro;
            boton.ForeColor = esSalir ? UiTheme.PrimarioTextoSuave : UiTheme.TextoSobrePrimario;

            if (boton.Dock == DockStyle.None)
                boton.Width = UiTheme.AnchoBotonMenu;

            if (boton.Height < UiTheme.AltoBoton)
                boton.Height = UiTheme.AltoBoton;

            AsignarIcono(boton);
        }

        /// <summary>
        /// Garantiza un alto/ancho mínimo para que ícono + texto entren cómodos.
        /// Nunca reduce el tamaño que ya tenía el control en el Designer.
        /// </summary>
        private static void AsegurarTamanoMinimo(Button boton)
        {
            if (boton.Height < UiTheme.AltoBoton)
                boton.Height = UiTheme.AltoBoton;

            boton.Width += UiTheme.AnchoExtraBoton;
        }

        // ---------------- Íconos ----------------

        // Glifos de "Segoe MDL2 Assets" (viene instalada con Windows 10/11).
        // El orden importa: se evalúa de arriba hacia abajo y gana la primera coincidencia,
        // por eso las claves más específicas ("cerrarsesion") van antes que las genéricas ("cerrar").
        // Para cambiar un ícono alcanza con tocar el char de esta lista.
        private static readonly (string Clave, char Glifo)[] Iconos =
        {
            ("cerrarsesion", ''),
            ("cambiarpassword", ''),
            ("nuevo", ''),
            ("guardar", ''),
            ("ingresar", ''),
            ("editar", ''),
            ("desactivar", ''),
            ("eliminar", ''),
            ("buscar", ''),
            ("refrescar", ''),
            ("cancelar", ''),
            ("productos", ''),
            ("categorias", ''),
            ("proveedores", ''),
            ("movimientos", ''),
            ("usuarios", ''),
            ("salir", ''),
            ("cerrar", ''),
        };

        private static void AsignarIcono(Button boton)
        {
            if (string.IsNullOrEmpty(boton.Name)) return;

            var nombre = boton.Name.ToLowerInvariant();

            foreach (var (clave, glifo) in Iconos)
            {
                if (!nombre.Contains(clave)) continue;

                boton.Image = CrearBitmapIcono(glifo, boton.ForeColor);
                boton.ImageAlign = ContentAlignment.MiddleLeft;
                boton.TextAlign = ContentAlignment.MiddleLeft;
                boton.TextImageRelation = TextImageRelation.ImageBeforeText;
                boton.Padding = new Padding(10, 0, 4, 0);
                return;
            }
        }

        private static Bitmap CrearBitmapIcono(char glifo, Color color)
        {
            // Los glifos de Segoe MDL2 Assets tienen un alto/ancho real mayor al tamaño de fuente
            // nominal (ascenso/descenso de la fuente). Si se dibujan dentro de un rectángulo muy
            // ajustado, DrawString los recorta. Por eso el lienzo es bastante más grande que
            // TamanoIcono, y se centra según el tamaño real medido (MeasureString), sin rectángulo
            // acotado (DrawString con PointF no recorta).
            var tamanoLienzo = UiTheme.TamanoIcono + 12;
            var bitmap = new Bitmap(tamanoLienzo, tamanoLienzo);

            using var g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            using var fuenteIcono = new Font(UiTheme.FuenteIconos, UiTheme.TamanoIcono, GraphicsUnit.Pixel);
            using var pincel = new SolidBrush(color);

            var texto = glifo.ToString();
            var medida = g.MeasureString(texto, fuenteIcono);
            var posicion = new PointF(
                (tamanoLienzo - medida.Width) / 2f,
                (tamanoLienzo - medida.Height) / 2f);

            g.DrawString(texto, fuenteIcono, pincel, posicion);
            return bitmap;
        }

        // ---------------- Utilidades de recorrido ----------------

        private static IEnumerable<Control> TodosLosControles(Control raiz)
        {
            foreach (Control hijo in raiz.Controls)
            {
                yield return hijo;

                foreach (var nieto in TodosLosControles(hijo))
                    yield return nieto;
            }
        }

        private static bool EstaDentroDe(Control control, string nombreContenedor)
        {
            var actual = control.Parent;
            while (actual != null)
            {
                if (actual.Name == nombreContenedor)
                    return true;

                actual = actual.Parent;
            }

            return false;
        }
    }
}
