namespace GestionInventario.Forms.Categorias
{
    partial class CategoriasForm
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
            txtBuscar = new System.Windows.Forms.TextBox();
            lblBuscar = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            panelBottom = new System.Windows.Forms.Panel();
            btnCerrar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            dgvCategorias = new System.Windows.Forms.DataGridView();
            colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnRefrescar);
            panelTop.Controls.Add(btnBuscar);
            panelTop.Controls.Add(txtBuscar);
            panelTop.Controls.Add(lblBuscar);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(969, 94);
            panelTop.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new System.Drawing.Point(680, 16);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new System.Drawing.Size(135, 55);
            btnRefrescar.TabIndex = 4;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(380, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(135, 55);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(198, 24);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(150, 27);
            txtBuscar.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new System.Drawing.Point(137, 27);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(55, 20);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Buscar:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.Location = new System.Drawing.Point(23, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(83, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Categorías";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnCerrar);
            panelBottom.Controls.Add(btnEliminar);
            panelBottom.Controls.Add(btnEditar);
            panelBottom.Controls.Add(btnNuevo);
            panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelBottom.Location = new System.Drawing.Point(0, 426);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new System.Drawing.Size(969, 108);
            panelBottom.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new System.Drawing.Point(680, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(156, 58);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(330, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(154, 58);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new System.Drawing.Point(171, 10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(153, 58);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new System.Drawing.Point(12, 10);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(153, 58);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colNombre, colDescripcion });
            dgvCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCategorias.Location = new System.Drawing.Point(0, 94);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersWidth = 25;
            dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new System.Drawing.Size(969, 332);
            dgvCategorias.TabIndex = 1;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 200;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            colDescripcion.Width = 400;
            // 
            // CategoriasForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(969, 534);
            Controls.Add(dgvCategorias);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "CategoriasForm";
            Text = "Categorías";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
    }
}