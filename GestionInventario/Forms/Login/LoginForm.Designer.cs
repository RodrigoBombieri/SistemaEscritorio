namespace GestionInventario.Forms.Login
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnIngresar = new System.Windows.Forms.Button();
            lblError = new System.Windows.Forms.Label();
            lblUsuario = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new System.Drawing.Point(325, 160);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(125, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(325, 207);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(125, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new System.Drawing.Point(339, 265);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(94, 29);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = System.Drawing.Color.Red;
            lblError.Location = new System.Drawing.Point(362, 323);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(41, 20);
            lblError.TabIndex = 3;
            lblError.Text = "Error";
            lblError.Visible = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new System.Drawing.Point(240, 167);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(62, 20);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(240, 214);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(73, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Controls.Add(lblError);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
    }
}