namespace GestionInventario.Forms.Productos
{
    partial class ProductosForm
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
            panelTop = new System.Windows.Forms.Panel();
            btnRefrescar = new System.Windows.Forms.Button();
            chkSoloStockBajo = new System.Windows.Forms.CheckBox();
            cmbCategoria = new System.Windows.Forms.ComboBox();
            lblCategoria = new System.Windows.Forms.Label();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblBuscar = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            panelBottom = new System.Windows.Forms.Panel();
            btnCerrar = new System.Windows.Forms.Button();
            btnDesactivar = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            dgvProductos = new System.Windows.Forms.DataGridView();
            colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            //
            // panelTop
            //
            panelTop.Controls.Add(btnRefrescar);
            panelTop.Controls.Add(chkSoloStockBajo);
            panelTop.Controls.Add(cmbCategoria);
            panelTop.Controls.Add(lblCategoria);
            panelTop.Controls.Add(btnBuscar);
            panelTop.Controls.Add(txtBuscar);
            panelTop.Controls.Add(lblBuscar);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(984, 56);
            panelTop.TabIndex = 0;
            //
            // btnRefrescar
            //
            btnRefrescar.Location = new System.Drawing.Point(860, 16);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new System.Drawing.Size(100, 29);
            btnRefrescar.TabIndex = 7;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            //
            // chkSoloStockBajo
            //
            chkSoloStockBajo.AutoSize = true;
            chkSoloStockBajo.Location = new System.Drawing.Point(650, 20);
            chkSoloStockBajo.Name = "chkSoloStockBajo";
            chkSoloStockBajo.Size = new System.Drawing.Size(130, 24);
            chkSoloStockBajo.TabIndex = 6;
            chkSoloStockBajo.Text = "Solo stock bajo";
            chkSoloStockBajo.UseVisualStyleBackColor = true;
            chkSoloStockBajo.CheckedChanged += chkSoloStockBajo_CheckedChanged;
            //
            // cmbCategoria
            //
            cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategoria.Location = new System.Drawing.Point(500, 17);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new System.Drawing.Size(140, 28);
            cmbCategoria.TabIndex = 5;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            //
            // lblCategoria
            //
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new System.Drawing.Point(425, 20);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new System.Drawing.Size(76, 20);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoría:";
            //
            // btnBuscar
            //
            btnBuscar.Location = new System.Drawing.Point(340, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            //
            // txtBuscar
            //
            txtBuscar.Location = new System.Drawing.Point(180, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(150, 27);
            txtBuscar.TabIndex = 2;
            //
            // lblBuscar
            //
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new System.Drawing.Point(120, 20);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(58, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.Location = new System.Drawing.Point(16, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(90, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Productos";
            //
            // panelBottom
            //
            panelBottom.Controls.Add(btnCerrar);
            panelBottom.Controls.Add(btnDesactivar);
            panelBottom.Controls.Add(btnEditar);
            panelBottom.Controls.Add(btnNuevo);
            panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBottom.Location = new System.Drawing.Point(0, 511);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new System.Drawing.Size(984, 50);
            panelBottom.TabIndex = 2;
            //
            // btnCerrar
            //
            btnCerrar.Location = new System.Drawing.Point(880, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(90, 29);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            //
            // btnDesactivar
            //
            btnDesactivar.Location = new System.Drawing.Point(230, 10);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new System.Drawing.Size(110, 29);
            btnDesactivar.TabIndex = 2;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = true;
            btnDesactivar.Click += btnDesactivar_Click;
            //
            // btnEditar
            //
            btnEditar.Location = new System.Drawing.Point(120, 10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(90, 29);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            //
            // btnNuevo
            //
            btnNuevo.Location = new System.Drawing.Point(16, 10);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(90, 29);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            //
            // dgvProductos
            //
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colCodigo, colNombre, colCategoria, colProveedor, colPrecioVenta, colStockActual, colStockMinimo, colActivo });
            dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvProductos.Location = new System.Drawing.Point(0, 56);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 25;
            dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new System.Drawing.Size(984, 455);
            dgvProductos.TabIndex = 1;
            //
            // colCodigo
            //
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            colCodigo.Width = 100;
            //
            // colNombre
            //
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 200;
            //
            // colCategoria
            //
            colCategoria.HeaderText = "Categoría";
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 130;
            //
            // colProveedor
            //
            colProveedor.HeaderText = "Proveedor";
            colProveedor.Name = "colProveedor";
            colProveedor.ReadOnly = true;
            colProveedor.Width = 160;
            //
            // colPrecioVenta
            //
            colPrecioVenta.HeaderText = "Precio Venta";
            colPrecioVenta.Name = "colPrecioVenta";
            colPrecioVenta.ReadOnly = true;
            colPrecioVenta.Width = 100;
            //
            // colStockActual
            //
            colStockActual.HeaderText = "Stock";
            colStockActual.Name = "colStockActual";
            colStockActual.ReadOnly = true;
            colStockActual.Width = 70;
            //
            // colStockMinimo
            //
            colStockMinimo.HeaderText = "Stock Mín.";
            colStockMinimo.Name = "colStockMinimo";
            colStockMinimo.ReadOnly = true;
            colStockMinimo.Width = 80;
            //
            // colActivo
            //
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            colActivo.Width = 60;
            //
            // ProductosForm
            //
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 561);
            Controls.Add(dgvProductos);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "ProductosForm";
            Text = "Productos";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.CheckBox chkSoloStockBajo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivo;
    }
}