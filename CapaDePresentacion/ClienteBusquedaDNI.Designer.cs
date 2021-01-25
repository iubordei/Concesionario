
namespace CapaDePresentacion
{
    partial class ClienteBusquedaDNI
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
            this.lblDNI = new System.Windows.Forms.Label();
            this.comboDNIs = new System.Windows.Forms.ComboBox();
            this.clienteInfo1 = new CapaDePresentacion.ClienteInfo();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(42, 42);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // comboDNIs
            // 
            this.comboDNIs.FormattingEnabled = true;
            this.comboDNIs.Location = new System.Drawing.Point(94, 39);
            this.comboDNIs.Name = "comboDNIs";
            this.comboDNIs.Size = new System.Drawing.Size(121, 21);
            this.comboDNIs.TabIndex = 1;
            this.comboDNIs.SelectedIndexChanged += new System.EventHandler(this.comboDNIs_SelectedIndexChanged);
            // 
            // clienteInfo1
            // 
            this.clienteInfo1.Apellidos = null;
            this.clienteInfo1.Location = new System.Drawing.Point(22, 66);
            this.clienteInfo1.Name = "clienteInfo1";
            this.clienteInfo1.Nombre = null;
            this.clienteInfo1.Size = new System.Drawing.Size(220, 120);
            this.clienteInfo1.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(94, 192);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // ClienteBusquedaDNI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 235);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.clienteInfo1);
            this.Controls.Add(this.comboDNIs);
            this.Controls.Add(this.lblDNI);
            this.Name = "ClienteBusquedaDNI";
            this.Text = "Datos de un cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.ComboBox comboDNIs;
        private ClienteInfo clienteInfo1;
        private System.Windows.Forms.Button btnCerrar;
    }
}