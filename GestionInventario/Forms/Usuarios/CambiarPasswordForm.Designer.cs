namespace GestionInventario.Forms.Usuarios
{
    partial class CambiarPasswordForm
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
            lblUsuario = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblConfirmarPassword = new System.Windows.Forms.Label();
            txtConfirmarPassword = new System.Windows.Forms.TextBox();
            lblError = new System.Windows.Forms.Label();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblUsuario.Location = new System.Drawing.Point(24, 20);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(71, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario: ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(24, 60);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(132, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Nueva Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(24, 83);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new System.Drawing.Size(280, 27);
            txtPassword.TabIndex = 2;
            // 
            // lblConfirmarPassword
            // 
            lblConfirmarPassword.AutoSize = true;
            lblConfirmarPassword.Location = new System.Drawing.Point(24, 120);
            lblConfirmarPassword.Name = "lblConfirmarPassword";
            lblConfirmarPassword.Size = new System.Drawing.Size(156, 20);
            lblConfirmarPassword.TabIndex = 3;
            lblConfirmarPassword.Text = "Confirmar Contraseña:";
            // 
            // txtConfirmarPassword
            // 
            txtConfirmarPassword.Location = new System.Drawing.Point(24, 143);
            txtConfirmarPassword.Name = "txtConfirmarPassword";
            txtConfirmarPassword.PasswordChar = '●';
            txtConfirmarPassword.Size = new System.Drawing.Size(280, 27);
            txtConfirmarPassword.TabIndex = 4;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(24, 180);
            lblError.MaximumSize = new System.Drawing.Size(280, 0);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(41, 20);
            lblError.TabIndex = 5;
            lblError.Text = "Error";
            lblError.Visible = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(24, 225);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(135, 55);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(169, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(135, 55);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CambiarPasswordForm
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new System.Drawing.Size(491, 374);
            Controls.Add(lblUsuario);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblConfirmarPassword);
            Controls.Add(txtConfirmarPassword);
            Controls.Add(lblError);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CambiarPasswordForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Cambiar Contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmarPassword;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}