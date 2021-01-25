
namespace CapaDePresentacion
{
    partial class LogIn
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(117, 128);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(12, 38);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(200, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 74);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Contraseña";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 128);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 164);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogin);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnSalir;
    }
}