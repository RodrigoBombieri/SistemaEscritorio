namespace GestionInventario.Forms.Movimientos
{
    partial class RegistrarMovimientoForm
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
            lblProducto = new System.Windows.Forms.Label();
            cmbProducto = new System.Windows.Forms.ComboBox();
            lblStockActual = new System.Windows.Forms.Label();
            lblCantidad = new System.Windows.Forms.Label();
            numCantidad = new System.Windows.Forms.NumericUpDown();
            lblMotivo = new System.Windows.Forms.Label();
            txtMotivo = new System.Windows.Forms.TextBox();
            lblError = new System.Windows.Forms.Label();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new System.Drawing.Point(24, 24);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new System.Drawing.Size(72, 20);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProducto.Location = new System.Drawing.Point(160, 21);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new System.Drawing.Size(300, 28);
            cmbProducto.TabIndex = 1;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.ForeColor = System.Drawing.Color.Gray;
            lblStockActual.Location = new System.Drawing.Point(160, 55);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new System.Drawing.Size(102, 20);
            lblStockActual.TabIndex = 2;
            lblStockActual.Text = "Stock actual: -";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new System.Drawing.Point(24, 98);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(72, 20);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad:";
            // 
            // numCantidad
            // 
            numCantidad.Location = new System.Drawing.Point(160, 96);
            numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new System.Drawing.Size(150, 27);
            numCantidad.TabIndex = 4;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new System.Drawing.Point(24, 135);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new System.Drawing.Size(59, 20);
            lblMotivo.TabIndex = 5;
            lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new System.Drawing.Point(160, 132);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new System.Drawing.Size(300, 70);
            txtMotivo.TabIndex = 6;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(24, 215);
            lblError.MaximumSize = new System.Drawing.Size(440, 0);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(41, 20);
            lblError.TabIndex = 7;
            lblError.Text = "Error";
            lblError.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(175, 260);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(135, 55);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(325, 260);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(135, 55);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // RegistrarMovimientoForm
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(600, 389);
            Controls.Add(lblProducto);
            Controls.Add(cmbProducto);
            Controls.Add(lblStockActual);
            Controls.Add(lblCantidad);
            Controls.Add(numCantidad);
            Controls.Add(lblMotivo);
            Controls.Add(txtMotivo);
            Controls.Add(lblError);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrarMovimientoForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Movimiento de Stock";
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
