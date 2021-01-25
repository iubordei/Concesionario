namespace CapaDePresentacion
{
    partial class VehiculoAgregarClave
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
            this.btAceptar = new System.Windows.Forms.Button();
            this.tbNumeroBastidor = new System.Windows.Forms.TextBox();
            this.lbNumeroBastidor = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(76, 120);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // tbNumeroBastidor
            // 
            this.tbNumeroBastidor.Location = new System.Drawing.Point(198, 50);
            this.tbNumeroBastidor.Name = "tbNumeroBastidor";
            this.tbNumeroBastidor.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroBastidor.TabIndex = 1;
            // 
            // lbNumeroBastidor
            // 
            this.lbNumeroBastidor.AutoSize = true;
            this.lbNumeroBastidor.Location = new System.Drawing.Point(59, 53);
            this.lbNumeroBastidor.Name = "lbNumeroBastidor";
            this.lbNumeroBastidor.Size = new System.Drawing.Size(102, 13);
            this.lbNumeroBastidor.TabIndex = 2;
            this.lbNumeroBastidor.Text = "Número de bastidor:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(209, 120);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // VehiculoAgregarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 179);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbNumeroBastidor);
            this.Controls.Add(this.tbNumeroBastidor);
            this.Controls.Add(this.btAceptar);
            this.Name = "VehiculoAgregarClave";
            this.Text = "Introducir número de bastidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox tbNumeroBastidor;
        private System.Windows.Forms.Label lbNumeroBastidor;
        private System.Windows.Forms.Button btCancelar;
    }
}