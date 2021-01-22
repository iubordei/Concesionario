
namespace CapaDePresentacion
{
    partial class PresupuestoAlta
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
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.listBoxVehiculos = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtValoracion = new System.Windows.Forms.TextBox();
            this.btnAgregarValoracion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(13, 13);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(214, 290);
            this.listBoxClientes.TabIndex = 0;
            // 
            // listBoxVehiculos
            // 
            this.listBoxVehiculos.FormattingEnabled = true;
            this.listBoxVehiculos.Location = new System.Drawing.Point(233, 12);
            this.listBoxVehiculos.Name = "listBoxVehiculos";
            this.listBoxVehiculos.Size = new System.Drawing.Size(214, 264);
            this.listBoxVehiculos.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(123, 309);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtValoracion
            // 
            this.txtValoracion.Location = new System.Drawing.Point(233, 283);
            this.txtValoracion.Name = "txtValoracion";
            this.txtValoracion.Size = new System.Drawing.Size(214, 20);
            this.txtValoracion.TabIndex = 4;
            // 
            // btnAgregarValoracion
            // 
            this.btnAgregarValoracion.Location = new System.Drawing.Point(233, 309);
            this.btnAgregarValoracion.Name = "btnAgregarValoracion";
            this.btnAgregarValoracion.Size = new System.Drawing.Size(213, 23);
            this.btnAgregarValoracion.TabIndex = 5;
            this.btnAgregarValoracion.Text = "Añadir valoración";
            this.btnAgregarValoracion.UseVisualStyleBackColor = true;
            this.btnAgregarValoracion.Click += new System.EventHandler(this.btnAgregarValoracion_Click);
            // 
            // PresupuestoAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 344);
            this.Controls.Add(this.btnAgregarValoracion);
            this.Controls.Add(this.txtValoracion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.listBoxVehiculos);
            this.Controls.Add(this.listBoxClientes);
            this.Name = "PresupuestoAlta";
            this.Text = "Alta de presupuesto";
            this.Load += new System.EventHandler(this.PresupuestoAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.ListBox listBoxVehiculos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtValoracion;
        private System.Windows.Forms.Button btnAgregarValoracion;
    }
}