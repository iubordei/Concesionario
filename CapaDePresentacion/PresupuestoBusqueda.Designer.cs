
namespace CapaDePresentacion
{
    partial class PresupuestoBusqueda
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
            this.grpTipoBusqueda = new System.Windows.Forms.GroupBox();
            this.rdBtnEstado = new System.Windows.Forms.RadioButton();
            this.rdBtnVehiculo = new System.Windows.Forms.RadioButton();
            this.rdBtnCliente = new System.Windows.Forms.RadioButton();
            this.listBoxParametros = new System.Windows.Forms.ListBox();
            this.lblParametros = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpTipoBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTipoBusqueda
            // 
            this.grpTipoBusqueda.Controls.Add(this.rdBtnEstado);
            this.grpTipoBusqueda.Controls.Add(this.rdBtnVehiculo);
            this.grpTipoBusqueda.Controls.Add(this.rdBtnCliente);
            this.grpTipoBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grpTipoBusqueda.Name = "grpTipoBusqueda";
            this.grpTipoBusqueda.Size = new System.Drawing.Size(360, 100);
            this.grpTipoBusqueda.TabIndex = 0;
            this.grpTipoBusqueda.TabStop = false;
            this.grpTipoBusqueda.Text = "Tipo de búsqueda";
            // 
            // rdBtnEstado
            // 
            this.rdBtnEstado.AutoSize = true;
            this.rdBtnEstado.Location = new System.Drawing.Point(6, 67);
            this.rdBtnEstado.Name = "rdBtnEstado";
            this.rdBtnEstado.Size = new System.Drawing.Size(77, 17);
            this.rdBtnEstado.TabIndex = 2;
            this.rdBtnEstado.TabStop = true;
            this.rdBtnEstado.Text = "Por Estado";
            this.rdBtnEstado.UseVisualStyleBackColor = true;
            this.rdBtnEstado.CheckedChanged += new System.EventHandler(this.rdBtnEstado_CheckedChanged);
            // 
            // rdBtnVehiculo
            // 
            this.rdBtnVehiculo.AutoSize = true;
            this.rdBtnVehiculo.Location = new System.Drawing.Point(7, 44);
            this.rdBtnVehiculo.Name = "rdBtnVehiculo";
            this.rdBtnVehiculo.Size = new System.Drawing.Size(85, 17);
            this.rdBtnVehiculo.TabIndex = 1;
            this.rdBtnVehiculo.TabStop = true;
            this.rdBtnVehiculo.Text = "Por Vehiculo";
            this.rdBtnVehiculo.UseVisualStyleBackColor = true;
            this.rdBtnVehiculo.CheckedChanged += new System.EventHandler(this.rdBtnVehiculo_CheckedChanged);
            // 
            // rdBtnCliente
            // 
            this.rdBtnCliente.AutoSize = true;
            this.rdBtnCliente.Location = new System.Drawing.Point(7, 20);
            this.rdBtnCliente.Name = "rdBtnCliente";
            this.rdBtnCliente.Size = new System.Drawing.Size(76, 17);
            this.rdBtnCliente.TabIndex = 0;
            this.rdBtnCliente.TabStop = true;
            this.rdBtnCliente.Text = "Por Cliente";
            this.rdBtnCliente.UseVisualStyleBackColor = true;
            this.rdBtnCliente.CheckedChanged += new System.EventHandler(this.rdBtnCliente_CheckedChanged);
            // 
            // listBoxParametros
            // 
            this.listBoxParametros.FormattingEnabled = true;
            this.listBoxParametros.Location = new System.Drawing.Point(12, 142);
            this.listBoxParametros.Name = "listBoxParametros";
            this.listBoxParametros.Size = new System.Drawing.Size(360, 121);
            this.listBoxParametros.TabIndex = 1;
            // 
            // lblParametros
            // 
            this.lblParametros.AutoSize = true;
            this.lblParametros.Location = new System.Drawing.Point(9, 126);
            this.lblParametros.Name = "lblParametros";
            this.lblParametros.Size = new System.Drawing.Size(120, 13);
            this.lblParametros.TabIndex = 3;
            this.lblParametros.Text = "Parámetro de búsqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(202, 269);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 269);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(170, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PresupuestoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 301);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblParametros);
            this.Controls.Add(this.listBoxParametros);
            this.Controls.Add(this.grpTipoBusqueda);
            this.Name = "PresupuestoBusqueda";
            this.Text = "PresupuestoBusqueda";
            this.Load += new System.EventHandler(this.PresupuestoBusqueda_Load);
            this.grpTipoBusqueda.ResumeLayout(false);
            this.grpTipoBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTipoBusqueda;
        private System.Windows.Forms.RadioButton rdBtnEstado;
        private System.Windows.Forms.RadioButton rdBtnVehiculo;
        private System.Windows.Forms.RadioButton rdBtnCliente;
        private System.Windows.Forms.ListBox listBoxParametros;
        private System.Windows.Forms.Label lblParametros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
    }
}