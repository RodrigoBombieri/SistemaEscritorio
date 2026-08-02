namespace GestionInventario.Forms.Productos
{
    partial class ProductoEditForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblCodigo = new System.Windows.Forms.Label();
            txtCodigo = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            lblDescripcion = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            lblCategoria = new System.Windows.Forms.Label();
            cmbCategoria = new System.Windows.Forms.ComboBox();
            lblProveedor = new System.Windows.Forms.Label();
            cmbProveedor = new System.Windows.Forms.ComboBox();
            lblPrecioCosto = new System.Windows.Forms.Label();
            numPrecioCosto = new System.Windows.Forms.NumericUpDown();
            lblPrecioVenta = new System.Windows.Forms.Label();
            numPrecioVenta = new System.Windows.Forms.NumericUpDown();
            lblStockActual = new System.Windows.Forms.Label();
            numStockActual = new System.Windows.Forms.NumericUpDown();
            lblStockNota = new System.Windows.Forms.Label();
            lblStockMinimo = new System.Windows.Forms.Label();
            numStockMinimo = new System.Windows.Forms.NumericUpDown();
            lblError = new System.Windows.Forms.Label();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numPrecioCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockMinimo).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new System.Drawing.Point(24, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(61, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new System.Drawing.Point(160, 21);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(200, 27);
            txtCodigo.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(24, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(160, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(340, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(24, 98);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(90, 20);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(160, 95);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(340, 60);
            txtDescripcion.TabIndex = 5;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new System.Drawing.Point(24, 172);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new System.Drawing.Size(77, 20);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new System.Drawing.Point(160, 169);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new System.Drawing.Size(200, 28);
            cmbCategoria.TabIndex = 7;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new System.Drawing.Point(24, 209);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new System.Drawing.Size(80, 20);
            lblProveedor.TabIndex = 8;
            lblProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProveedor.Location = new System.Drawing.Point(160, 206);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new System.Drawing.Size(300, 28);
            cmbProveedor.TabIndex = 9;
            // 
            // lblPrecioCosto
            // 
            lblPrecioCosto.AutoSize = true;
            lblPrecioCosto.Location = new System.Drawing.Point(24, 254);
            lblPrecioCosto.Name = "lblPrecioCosto";
            lblPrecioCosto.Size = new System.Drawing.Size(95, 20);
            lblPrecioCosto.TabIndex = 10;
            lblPrecioCosto.Text = "Precio Costo:";
            // 
            // numPrecioCosto
            // 
            numPrecioCosto.DecimalPlaces = 2;
            numPrecioCosto.Location = new System.Drawing.Point(160, 252);
            numPrecioCosto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPrecioCosto.Name = "numPrecioCosto";
            numPrecioCosto.Size = new System.Drawing.Size(150, 27);
            numPrecioCosto.TabIndex = 11;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new System.Drawing.Point(340, 254);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new System.Drawing.Size(94, 20);
            lblPrecioVenta.TabIndex = 12;
            lblPrecioVenta.Text = "Precio Venta:";
            // 
            // numPrecioVenta
            // 
            numPrecioVenta.DecimalPlaces = 2;
            numPrecioVenta.Location = new System.Drawing.Point(460, 252);
            numPrecioVenta.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numPrecioVenta.Name = "numPrecioVenta";
            numPrecioVenta.Size = new System.Drawing.Size(150, 27);
            numPrecioVenta.TabIndex = 13;
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Location = new System.Drawing.Point(24, 291);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new System.Drawing.Size(94, 20);
            lblStockActual.TabIndex = 14;
            lblStockActual.Text = "Stock Actual:";
            // 
            // numStockActual
            // 
            numStockActual.Location = new System.Drawing.Point(160, 289);
            numStockActual.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numStockActual.Name = "numStockActual";
            numStockActual.Size = new System.Drawing.Size(150, 27);
            numStockActual.TabIndex = 15;
            // 
            // lblStockNota
            // 
            lblStockNota.AutoSize = true;
            lblStockNota.ForeColor = System.Drawing.Color.Gray;
            lblStockNota.Location = new System.Drawing.Point(320, 292);
            lblStockNota.Name = "lblStockNota";
            lblStockNota.Size = new System.Drawing.Size(257, 20);
            lblStockNota.TabIndex = 16;
            lblStockNota.Text = "El stock se ajusta desde Movimientos.";
            lblStockNota.Visible = false;
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Location = new System.Drawing.Point(24, 328);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new System.Drawing.Size(103, 20);
            lblStockMinimo.TabIndex = 17;
            lblStockMinimo.Text = "Stock Mínimo:";
            // 
            // numStockMinimo
            // 
            numStockMinimo.Location = new System.Drawing.Point(160, 326);
            numStockMinimo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numStockMinimo.Name = "numStockMinimo";
            numStockMinimo.Size = new System.Drawing.Size(150, 27);
            numStockMinimo.TabIndex = 18;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(24, 370);
            lblError.MaximumSize = new System.Drawing.Size(480, 0);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(41, 20);
            lblError.TabIndex = 19;
            lblError.Text = "Error";
            lblError.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(320, 420);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(135, 55);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(460, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(135, 55);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ProductoEditForm
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(636, 529);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(lblProveedor);
            Controls.Add(cmbProveedor);
            Controls.Add(lblPrecioCosto);
            Controls.Add(numPrecioCosto);
            Controls.Add(lblPrecioVenta);
            Controls.Add(numPrecioVenta);
            Controls.Add(lblStockActual);
            Controls.Add(numStockActual);
            Controls.Add(lblStockNota);
            Controls.Add(lblStockMinimo);
            Controls.Add(numStockMinimo);
            Controls.Add(lblError);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductoEditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)numPrecioCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockMinimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.NumericUpDown numPrecioCosto;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.NumericUpDown numPrecioVenta;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.NumericUpDown numStockActual;
        private System.Windows.Forms.Label lblStockNota;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.NumericUpDown numStockMinimo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}