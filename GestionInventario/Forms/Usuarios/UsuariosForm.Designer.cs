namespace GestionInventario.Forms.Usuarios
{
    partial class UsuariosForm
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
            btnCambiarPassword = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            dgvUsuarios = new System.Windows.Forms.DataGridView();
            colNombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
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
            panelTop.Size = new System.Drawing.Size(984, 56);
            panelTop.TabIndex = 0;
            //
            // btnRefrescar
            //
            btnRefrescar.Location = new System.Drawing.Point(650, 16);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new System.Drawing.Size(100, 29);
            btnRefrescar.TabIndex = 4;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            //
            // chkSoloActivos
            //
            chkSoloActivos.AutoSize = true;
            chkSoloActivos.Checked = true;
            chkSoloActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            chkSoloActivos.Location = new System.Drawing.Point(500, 20);
            chkSoloActivos.Name = "chkSoloActivos";
            chkSoloActivos.Size = new System.Drawing.Size(110, 24);
            chkSoloActivos.TabIndex = 3;
            chkSoloActivos.Text = "Solo activos";
            chkSoloActivos.UseVisualStyleBackColor = true;
            chkSoloActivos.CheckedChanged += chkSoloActivos_CheckedChanged;
            //
            // btnBuscar
            //
            btnBuscar.Location = new System.Drawing.Point(340, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            //
            // txtBuscar
            //
            txtBuscar.Location = new System.Drawing.Point(180, 17);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(150, 27);
            txtBuscar.TabIndex = 1;
            //
            // lblBuscar
            //
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new System.Drawing.Point(120, 20);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(58, 20);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar:";
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.Location = new System.Drawing.Point(16, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(80, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Usuarios";
            //
            // panelBottom
            //
            panelBottom.Controls.Add(btnCerrar);
            panelBottom.Controls.Add(btnDesactivar);
            panelBottom.Controls.Add(btnCambiarPassword);
            panelBottom.Controls.Add(btnEditar);
            panelBottom.Controls.Add(btnNuevo);
            panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBottom.Location = new System.Drawing.Point(0, 411);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new System.Drawing.Size(984, 50);
            panelBottom.TabIndex = 2;
            //
            // btnCerrar
            //
            btnCerrar.Location = new System.Drawing.Point(880, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(90, 29);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            //
            // btnDesactivar
            //
            btnDesactivar.Location = new System.Drawing.Point(390, 10);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new System.Drawing.Size(110, 29);
            btnDesactivar.TabIndex = 3;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = true;
            btnDesactivar.Click += btnDesactivar_Click;
            //
            // btnCambiarPassword
            //
            btnCambiarPassword.Location = new System.Drawing.Point(220, 10);
            btnCambiarPassword.Name = "btnCambiarPassword";
            btnCambiarPassword.Size = new System.Drawing.Size(160, 29);
            btnCambiarPassword.TabIndex = 2;
            btnCambiarPassword.Text = "Cambiar Contraseña";
            btnCambiarPassword.UseVisualStyleBackColor = true;
            btnCambiarPassword.Click += btnCambiarPassword_Click;
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
            // dgvUsuarios
            //
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colNombreUsuario, colNombreCompleto, colRol, colActivo });
            dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUsuarios.Location = new System.Drawing.Point(0, 56);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 25;
            dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new System.Drawing.Size(984, 355);
            dgvUsuarios.TabIndex = 1;
            //
            // colNombreUsuario
            //
            colNombreUsuario.HeaderText = "Usuario";
            colNombreUsuario.Name = "colNombreUsuario";
            colNombreUsuario.ReadOnly = true;
            colNombreUsuario.Width = 150;
            //
            // colNombreCompleto
            //
            colNombreCompleto.HeaderText = "Nombre Completo";
            colNombreCompleto.Name = "colNombreCompleto";
            colNombreCompleto.ReadOnly = true;
            colNombreCompleto.Width = 250;
            //
            // colRol
            //
            colRol.HeaderText = "Rol";
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            colRol.Width = 120;
            //
            // colActivo
            //
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            colActivo.Width = 60;
            //
            // UsuariosForm
            //
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 461);
            Controls.Add(dgvUsuarios);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "UsuariosForm";
            Text = "Usuarios";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
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
        private System.Windows.Forms.Button btnCambiarPassword;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivo;
    }
}