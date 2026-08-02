namespace GestionInventario.Forms.Usuarios
{
    partial class UsuarioEditForm
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
            lblNombreUsuario = new System.Windows.Forms.Label();
            txtNombreUsuario = new System.Windows.Forms.TextBox();
            lblNombreCompleto = new System.Windows.Forms.Label();
            txtNombreCompleto = new System.Windows.Forms.TextBox();
            lblRol = new System.Windows.Forms.Label();
            cmbRol = new System.Windows.Forms.ComboBox();
            panelPassword = new System.Windows.Forms.Panel();
            txtConfirmarPassword = new System.Windows.Forms.TextBox();
            lblConfirmarPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            lblError = new System.Windows.Forms.Label();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            panelPassword.SuspendLayout();
            SuspendLayout();
            //
            // lblNombreUsuario
            //
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new System.Drawing.Point(24, 24);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new System.Drawing.Size(130, 20);
            lblNombreUsuario.TabIndex = 0;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            //
            // txtNombreUsuario
            //
            txtNombreUsuario.Location = new System.Drawing.Point(190, 21);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new System.Drawing.Size(220, 27);
            txtNombreUsuario.TabIndex = 1;
            //
            // lblNombreCompleto
            //
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new System.Drawing.Point(24, 61);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new System.Drawing.Size(140, 20);
            lblNombreCompleto.TabIndex = 2;
            lblNombreCompleto.Text = "Nombre Completo:";
            //
            // txtNombreCompleto
            //
            txtNombreCompleto.Location = new System.Drawing.Point(190, 58);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new System.Drawing.Size(300, 27);
            txtNombreCompleto.TabIndex = 3;
            //
            // lblRol
            //
            lblRol.AutoSize = true;
            lblRol.Location = new System.Drawing.Point(24, 98);
            lblRol.Name = "lblRol";
            lblRol.Size = new System.Drawing.Size(37, 20);
            lblRol.TabIndex = 4;
            lblRol.Text = "Rol:";
            //
            // cmbRol
            //
            cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRol.Location = new System.Drawing.Point(190, 95);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new System.Drawing.Size(200, 28);
            cmbRol.TabIndex = 5;
            //
            // panelPassword
            //
            panelPassword.Controls.Add(lblPassword);
            panelPassword.Controls.Add(txtPassword);
            panelPassword.Controls.Add(lblConfirmarPassword);
            panelPassword.Controls.Add(txtConfirmarPassword);
            panelPassword.Location = new System.Drawing.Point(0, 135);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new System.Drawing.Size(510, 80);
            panelPassword.TabIndex = 6;
            //
            // lblPassword
            //
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(24, 5);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(96, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Contraseña:";
            //
            // txtPassword
            //
            txtPassword.Location = new System.Drawing.Point(190, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new System.Drawing.Size(200, 27);
            txtPassword.TabIndex = 1;
            //
            // lblConfirmarPassword
            //
            lblConfirmarPassword.AutoSize = true;
            lblConfirmarPassword.Location = new System.Drawing.Point(24, 42);
            lblConfirmarPassword.Name = "lblConfirmarPassword";
            lblConfirmarPassword.Size = new System.Drawing.Size(150, 20);
            lblConfirmarPassword.TabIndex = 2;
            lblConfirmarPassword.Text = "Confirmar Contraseña:";
            //
            // txtConfirmarPassword
            //
            txtConfirmarPassword.Location = new System.Drawing.Point(190, 39);
            txtConfirmarPassword.Name = "txtConfirmarPassword";
            txtConfirmarPassword.PasswordChar = '●';
            txtConfirmarPassword.Size = new System.Drawing.Size(200, 27);
            txtConfirmarPassword.TabIndex = 3;
            //
            // lblError
            //
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(24, 230);
            lblError.MaximumSize = new System.Drawing.Size(460, 0);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(41, 20);
            lblError.TabIndex = 7;
            lblError.Text = "Error";
            lblError.Visible = false;
            //
            // btnGuardar
            //
            btnGuardar.Location = new System.Drawing.Point(300, 275);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(90, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            //
            // btnCancelar
            //
            btnCancelar.Location = new System.Drawing.Point(400, 275);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(90, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // UsuarioEditForm
            //
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(510, 326);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblNombreCompleto);
            Controls.Add(txtNombreCompleto);
            Controls.Add(lblRol);
            Controls.Add(cmbRol);
            Controls.Add(panelPassword);
            Controls.Add(lblError);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuarioEditForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Usuario";
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmarPassword;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}