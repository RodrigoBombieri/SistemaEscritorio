namespace GestionInventario.Forms.Movimientos
{
    partial class MovimientosForm
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
            btnBuscar = new System.Windows.Forms.Button();
            dtpHasta = new System.Windows.Forms.DateTimePicker();
            dtpDesde = new System.Windows.Forms.DateTimePicker();
            chkFiltrarFecha = new System.Windows.Forms.CheckBox();
            cmbTipo = new System.Windows.Forms.ComboBox();
            lblTipo = new System.Windows.Forms.Label();
            cmbProducto = new System.Windows.Forms.ComboBox();
            lblProducto = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            panelBottom = new System.Windows.Forms.Panel();
            btnCerrar = new System.Windows.Forms.Button();
            btnAjuste = new System.Windows.Forms.Button();
            btnSalida = new System.Windows.Forms.Button();
            btnEntrada = new System.Windows.Forms.Button();
            dgvMovimientos = new System.Windows.Forms.DataGridView();
            colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnRefrescar);
            panelTop.Controls.Add(btnBuscar);
            panelTop.Controls.Add(dtpHasta);
            panelTop.Controls.Add(dtpDesde);
            panelTop.Controls.Add(chkFiltrarFecha);
            panelTop.Controls.Add(cmbTipo);
            panelTop.Controls.Add(lblTipo);
            panelTop.Controls.Add(cmbProducto);
            panelTop.Controls.Add(lblProducto);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1095, 88);
            panelTop.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new System.Drawing.Point(901, 10);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new System.Drawing.Size(135, 55);
            btnRefrescar.TabIndex = 9;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(716, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(135, 55);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Enabled = false;
            dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpHasta.Location = new System.Drawing.Point(589, 12);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new System.Drawing.Size(106, 27);
            dtpHasta.TabIndex = 7;
            // 
            // dtpDesde
            // 
            dtpDesde.Enabled = false;
            dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDesde.Location = new System.Drawing.Point(477, 12);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new System.Drawing.Size(106, 27);
            dtpDesde.TabIndex = 6;
            // 
            // chkFiltrarFecha
            // 
            chkFiltrarFecha.AutoSize = true;
            chkFiltrarFecha.Location = new System.Drawing.Point(320, 14);
            chkFiltrarFecha.Name = "chkFiltrarFecha";
            chkFiltrarFecha.Size = new System.Drawing.Size(136, 24);
            chkFiltrarFecha.TabIndex = 5;
            chkFiltrarFecha.Text = "Filtrar por fecha";
            chkFiltrarFecha.UseVisualStyleBackColor = true;
            chkFiltrarFecha.CheckedChanged += chkFiltrarFecha_CheckedChanged;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTipo.Location = new System.Drawing.Point(360, 48);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new System.Drawing.Size(130, 28);
            cmbTipo.TabIndex = 4;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new System.Drawing.Point(320, 51);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(42, 20);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo:";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbProducto.Location = new System.Drawing.Point(90, 48);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new System.Drawing.Size(210, 28);
            cmbProducto.TabIndex = 2;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new System.Drawing.Point(16, 51);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new System.Drawing.Size(72, 20);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.Location = new System.Drawing.Point(16, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(101, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Movimientos";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnCerrar);
            panelBottom.Controls.Add(btnAjuste);
            panelBottom.Controls.Add(btnSalida);
            panelBottom.Controls.Add(btnEntrada);
            panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBottom.Location = new System.Drawing.Point(0, 461);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new System.Drawing.Size(1095, 104);
            panelBottom.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new System.Drawing.Point(880, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(135, 55);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAjuste
            // 
            btnAjuste.Location = new System.Drawing.Point(320, 10);
            btnAjuste.Name = "btnAjuste";
            btnAjuste.Size = new System.Drawing.Size(135, 55);
            btnAjuste.TabIndex = 2;
            btnAjuste.Text = "Ajustar Stock";
            btnAjuste.UseVisualStyleBackColor = true;
            btnAjuste.Click += btnAjuste_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new System.Drawing.Point(165, 10);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new System.Drawing.Size(135, 55);
            btnSalida.TabIndex = 1;
            btnSalida.Text = "Nueva Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // btnEntrada
            // 
            btnEntrada.Location = new System.Drawing.Point(16, 10);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new System.Drawing.Size(135, 55);
            btnEntrada.TabIndex = 0;
            btnEntrada.Text = "Nueva Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.AllowUserToDeleteRows = false;
            dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colFecha, colProducto, colTipo, colCantidad, colMotivo, colUsuario });
            dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvMovimientos.Location = new System.Drawing.Point(0, 88);
            dgvMovimientos.MultiSelect = false;
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.RowHeadersWidth = 25;
            dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMovimientos.Size = new System.Drawing.Size(1095, 373);
            dgvMovimientos.TabIndex = 1;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 130;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 6;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            colProducto.Width = 220;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            colTipo.Width = 90;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 80;
            // 
            // colMotivo
            // 
            colMotivo.HeaderText = "Motivo";
            colMotivo.MinimumWidth = 6;
            colMotivo.Name = "colMotivo";
            colMotivo.ReadOnly = true;
            colMotivo.Width = 260;
            // 
            // colUsuario
            // 
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 6;
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            colUsuario.Width = 160;
            // 
            // MovimientosForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1095, 565);
            Controls.Add(dgvMovimientos);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "MovimientosForm";
            Text = "Movimientos";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.CheckBox chkFiltrarFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnAjuste;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
    }
}
