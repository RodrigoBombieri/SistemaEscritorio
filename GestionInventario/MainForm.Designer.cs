namespace GestionInventario
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new System.Windows.Forms.Panel();
            btnCerrarSesion = new System.Windows.Forms.Button();
            lblUsuario = new System.Windows.Forms.Label();
            lblTitulo = new System.Windows.Forms.Label();
            panelMenu = new System.Windows.Forms.Panel();
            flowMenu = new System.Windows.Forms.FlowLayoutPanel();
            btnProductos = new System.Windows.Forms.Button();
            btnCategorias = new System.Windows.Forms.Button();
            btnProveedores = new System.Windows.Forms.Button();
            btnMovimientos = new System.Windows.Forms.Button();
            btnUsuarios = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            panelTop.SuspendLayout();
            panelMenu.SuspendLayout();
            flowMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnCerrarSesion);
            panelTop.Controls.Add(lblUsuario);
            panelTop.Controls.Add(lblTitulo);
            panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(1059, 63);
            panelTop.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new System.Drawing.Point(870, 12);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new System.Drawing.Size(164, 48);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new System.Drawing.Point(558, 16);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(0, 20);
            lblUsuario.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitulo.Location = new System.Drawing.Point(16, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(160, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Inventario";
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(flowMenu);
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            panelMenu.Location = new System.Drawing.Point(0, 63);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new System.Drawing.Size(170, 517);
            panelMenu.TabIndex = 2;
            // 
            // flowMenu
            // 
            flowMenu.Controls.Add(btnProductos);
            flowMenu.Controls.Add(btnCategorias);
            flowMenu.Controls.Add(btnProveedores);
            flowMenu.Controls.Add(btnMovimientos);
            flowMenu.Controls.Add(btnUsuarios);
            flowMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            flowMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowMenu.Location = new System.Drawing.Point(0, 0);
            flowMenu.Name = "flowMenu";
            flowMenu.Size = new System.Drawing.Size(170, 488);
            flowMenu.TabIndex = 1;
            flowMenu.WrapContents = false;
            // 
            // btnProductos
            // 
            btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProductos.Location = new System.Drawing.Point(3, 3);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new System.Drawing.Size(145, 45);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCategorias.Location = new System.Drawing.Point(3, 54);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new System.Drawing.Size(145, 45);
            btnCategorias.TabIndex = 1;
            btnCategorias.Text = "Categorías";
            btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProveedores.Location = new System.Drawing.Point(3, 105);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new System.Drawing.Size(145, 45);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnMovimientos
            // 
            btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMovimientos.Location = new System.Drawing.Point(3, 156);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new System.Drawing.Size(145, 45);
            btnMovimientos.TabIndex = 3;
            btnMovimientos.Text = "Movimientos";
            btnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUsuarios.Location = new System.Drawing.Point(3, 207);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new System.Drawing.Size(145, 45);
            btnUsuarios.TabIndex = 4;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnSalir.Location = new System.Drawing.Point(0, 488);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(170, 29);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsslUsuario, toolStripStatusLabel1, tsslVersion });
            statusStrip1.Location = new System.Drawing.Point(170, 554);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(889, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsuario
            // 
            tsslUsuario.Name = "tsslUsuario";
            tsslUsuario.Size = new System.Drawing.Size(59, 20);
            tsslUsuario.Text = "Usuario";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(660, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // tsslVersion
            // 
            tsslVersion.Name = "tsslVersion";
            tsslVersion.Size = new System.Drawing.Size(155, 20);
            tsslVersion.Text = "GestionInventario v0.1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1059, 580);
            Controls.Add(statusStrip1);
            Controls.Add(panelMenu);
            Controls.Add(panelTop);
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "Gestión de Inventario";
            Load += MainForm_Load_1;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMenu.ResumeLayout(false);
            flowMenu.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.FlowLayoutPanel flowMenu;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
    }
}

