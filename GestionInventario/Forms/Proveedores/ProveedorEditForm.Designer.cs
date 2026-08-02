namespace GestionInventario.Forms.Proveedores
{
    partial class ProveedorEditForm
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
            lblRazonSocial = new System.Windows.Forms.Label();
            txtRazonSocial = new System.Windows.Forms.TextBox();
            lblCUIT = new System.Windows.Forms.Label();
            txtCUIT = new System.Windows.Forms.TextBox();
            lblTelefono = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblDireccion = new System.Windows.Forms.Label();
            txtDireccion = new System.Windows.Forms.TextBox();
            lblError = new System.Windows.Forms.Label();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new System.Drawing.Point(24, 24);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new System.Drawing.Size(97, 20);
            lblRazonSocial.TabIndex = 0;
            lblRazonSocial.Text = "Razón Social:";
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new System.Drawing.Point(160, 21);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new System.Drawing.Size(300, 27);
            txtRazonSocial.TabIndex = 1;
            // 
            // lblCUIT
            // 
            lblCUIT.AutoSize = true;
            lblCUIT.Location = new System.Drawing.Point(24, 61);
            lblCUIT.Name = "lblCUIT";
            lblCUIT.Size = new System.Drawing.Size(43, 20);
            lblCUIT.TabIndex = 2;
            lblCUIT.Text = "CUIT:";
            // 
            // txtCUIT
            // 
            txtCUIT.Location = new System.Drawing.Point(160, 58);
            txtCUIT.Name = "txtCUIT";
            txtCUIT.Size = new System.Drawing.Size(150, 27);
            txtCUIT.TabIndex = 3;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new System.Drawing.Point(24, 98);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(70, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(160, 95);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(150, 27);
            txtTelefono.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(24, 135);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(49, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(160, 132);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(300, 27);
            txtEmail.TabIndex = 7;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new System.Drawing.Point(24, 172);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new System.Drawing.Size(75, 20);
            lblDireccion.TabIndex = 8;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(160, 169);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(300, 60);
            txtDireccion.TabIndex = 9;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(24, 245);
            lblError.MaximumSize = new System.Drawing.Size(430, 0);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(41, 20);
            lblError.TabIndex = 10;
            lblError.Text = "Error";
            lblError.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(290, 290);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(85, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(385, 290);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(85, 29);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ProveedorEditForm
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(494, 341);
            Controls.Add(lblRazonSocial);
            Controls.Add(txtRazonSocial);
            Controls.Add(lblCUIT);
            Controls.Add(txtCUIT);
            Controls.Add(lblTelefono);
            Controls.Add(txtTelefono);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(lblError);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProveedorEditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Proveedor";
            Load += ProveedorEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}