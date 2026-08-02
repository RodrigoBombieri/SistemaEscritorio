namespace GestionInventario.Forms.Proveedores
{
    partial class ProveedoresForm
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
            chkSoloActivos = new System.Windows.Forms.CheckBox();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblBuscar = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            panelBottom = new System.Windows.Forms.Panel();
            btnCerrar = new System.Windows.Forms.Button();
            btnDesactivar = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            dgvProveedores = new System.Windows.Forms.DataGridView();
            colRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnRefrescar);
            panelTop.Controls.Add(chkSoloActivos);
            panelTop.Controls.Add(btnBuscar);
            panelTop.Controls.Add(txtBuscar);
            panelTop.Controls.Add(lblBuscar);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1076, 100);
            panelTop.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new System.Drawing.Point(826, 16);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new System.Drawing.Size(135, 55);
            btnRefrescar.TabIndex = 5;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // chkSoloActivos
            // 
            chkSoloActivos.AutoSize = true;
            chkSoloActivos.Checked = true;
            chkSoloActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSoloActivos.Location = new System.Drawing.Point(583, 32);
            chkSoloActivos.Name = "chkSoloActivos";
            chkSoloActivos.Size = new System.Drawing.Size(111, 24);
            chkSoloActivos.TabIndex = 4;
            chkSoloActivos.Text = "Solo activos";
            chkSoloActivos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(371, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(135, 55);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(202, 29);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(150, 27);
            txtBuscar.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new System.Drawing.Point(141, 33);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(55, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.Location = new System.Drawing.Point(12, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(96, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Proveedores";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnCerrar);
            panelBottom.Controls.Add(btnDesactivar);
            panelBottom.Controls.Add(btnEditar);
            panelBottom.Controls.Add(btnNuevo);
            panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBottom.Location = new System.Drawing.Point(0, 485);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new System.Drawing.Size(1076, 91);
            panelBottom.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new System.Drawing.Point(826, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(135, 55);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Location = new System.Drawing.Point(322, 10);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new System.Drawing.Size(135, 55);
            btnDesactivar.TabIndex = 2;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = true;
            btnDesactivar.Click += btnDesactivar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new System.Drawing.Point(163, 10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(135, 55);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new System.Drawing.Point(18, 10);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(135, 55);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AllowUserToAddRows = false;
            dgvProveedores.AllowUserToDeleteRows = false;
            dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colRazonSocial, colCUIT, colTelefono, colEmail, colDireccion, colActivo });
            dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvProveedores.Location = new System.Drawing.Point(0, 100);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 25;
            dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new System.Drawing.Size(1076, 385);
            dgvProveedores.TabIndex = 1;
            dgvProveedores.Click += chkSoloActivos_CheckedChanged;
            // 
            // colRazonSocial
            // 
            colRazonSocial.HeaderText = "Razón Social";
            colRazonSocial.MinimumWidth = 6;
            colRazonSocial.Name = "colRazonSocial";
            colRazonSocial.ReadOnly = true;
            colRazonSocial.Width = 200;
            // 
            // colCUIT
            // 
            colCUIT.HeaderText = "CUIT";
            colCUIT.MinimumWidth = 6;
            colCUIT.Name = "colCUIT";
            colCUIT.ReadOnly = true;
            colCUIT.Width = 110;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            colTelefono.Width = 110;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 180;
            // 
            // colDireccion
            // 
            colDireccion.HeaderText = "Dirección";
            colDireccion.MinimumWidth = 6;
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            colDireccion.Width = 200;
            // 
            // colActivo
            // 
            colActivo.HeaderText = "Activo";
            colActivo.MinimumWidth = 6;
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            colActivo.Width = 60;
            // 
            // ProveedoresForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1076, 576);
            Controls.Add(dgvProveedores);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "ProveedoresForm";
            Text = "Proveedores";
            Load += ProveedoresForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkSoloActivos;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivo;
    }
}