
namespace CapaDePresentacion
{
    partial class ClienteListado
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
            this.btnListadoDNI = new System.Windows.Forms.Button();
            this.btnListadoNombre = new System.Windows.Forms.Button();
            this.btnListadoCategoria = new System.Windows.Forms.Button();
            this.lboxDni = new System.Windows.Forms.ListBox();
            this.lboxNombre = new System.Windows.Forms.ListBox();
            this.lboxCategoria = new System.Windows.Forms.ListBox();
            this.btnListadoCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListadoDNI
            // 
            this.btnListadoDNI.Location = new System.Drawing.Point(29, 39);
            this.btnListadoDNI.Name = "btnListadoDNI";
            this.btnListadoDNI.Size = new System.Drawing.Size(120, 23);
            this.btnListadoDNI.TabIndex = 0;
            this.btnListadoDNI.Text = "DNI";
            this.btnListadoDNI.UseVisualStyleBackColor = true;
            this.btnListadoDNI.Click += new System.EventHandler(this.btnListadoDNI_Click);
            // 
            // btnListadoNombre
            // 
            this.btnListadoNombre.Location = new System.Drawing.Point(188, 39);
            this.btnListadoNombre.Name = "btnListadoNombre";
            this.btnListadoNombre.Size = new System.Drawing.Size(120, 23);
            this.btnListadoNombre.TabIndex = 1;
            this.btnListadoNombre.Text = "Nombre";
            this.btnListadoNombre.UseVisualStyleBackColor = true;
            this.btnListadoNombre.Click += new System.EventHandler(this.btnListadoNombre_Click);
            // 
            // btnListadoCategoria
            // 
            this.btnListadoCategoria.Location = new System.Drawing.Point(343, 39);
            this.btnListadoCategoria.Name = "btnListadoCategoria";
            this.btnListadoCategoria.Size = new System.Drawing.Size(120, 23);
            this.btnListadoCategoria.TabIndex = 2;
            this.btnListadoCategoria.Text = "Categoría";
            this.btnListadoCategoria.UseVisualStyleBackColor = true;
            this.btnListadoCategoria.Click += new System.EventHandler(this.btnListadoCategoria_Click);
            // 
            // lboxDni
            // 
            this.lboxDni.FormattingEnabled = true;
            this.lboxDni.Location = new System.Drawing.Point(29, 88);
            this.lboxDni.Name = "lboxDni";
            this.lboxDni.Size = new System.Drawing.Size(120, 225);
            this.lboxDni.TabIndex = 3;
            // 
            // lboxNombre
            // 
            this.lboxNombre.FormattingEnabled = true;
            this.lboxNombre.Location = new System.Drawing.Point(188, 88);
            this.lboxNombre.Name = "lboxNombre";
            this.lboxNombre.Size = new System.Drawing.Size(120, 225);
            this.lboxNombre.TabIndex = 4;
            // 
            // lboxCategoria
            // 
            this.lboxCategoria.FormattingEnabled = true;
            this.lboxCategoria.Location = new System.Drawing.Point(343, 88);
            this.lboxCategoria.Name = "lboxCategoria";
            this.lboxCategoria.Size = new System.Drawing.Size(120, 225);
            this.lboxCategoria.TabIndex = 5;
            // 
            // btnListadoCerrar
            // 
            this.btnListadoCerrar.Location = new System.Drawing.Point(188, 337);
            this.btnListadoCerrar.Name = "btnListadoCerrar";
            this.btnListadoCerrar.Size = new System.Drawing.Size(120, 23);
            this.btnListadoCerrar.TabIndex = 6;
            this.btnListadoCerrar.Text = "Cerrar";
            this.btnListadoCerrar.UseVisualStyleBackColor = true;
            this.btnListadoCerrar.Click += new System.EventHandler(this.btnListadoCerrar_Click);
            // 
            // ClienteListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 373);
            this.Controls.Add(this.btnListadoCerrar);
            this.Controls.Add(this.lboxCategoria);
            this.Controls.Add(this.lboxNombre);
            this.Controls.Add(this.lboxDni);
            this.Controls.Add(this.btnListadoCategoria);
            this.Controls.Add(this.btnListadoNombre);
            this.Controls.Add(this.btnListadoDNI);
            this.Name = "ClienteListado";
            this.Text = "Listado ordenado";
            this.Load += new System.EventHandler(this.ClienteListado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListadoDNI;
        private System.Windows.Forms.Button btnListadoNombre;
        private System.Windows.Forms.Button btnListadoCategoria;
        private System.Windows.Forms.ListBox lboxDni;
        private System.Windows.Forms.ListBox lboxNombre;
        private System.Windows.Forms.ListBox lboxCategoria;
        private System.Windows.Forms.Button btnListadoCerrar;
    }
}