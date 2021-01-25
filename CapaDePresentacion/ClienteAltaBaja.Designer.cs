namespace CapaDePresentacion
{
    partial class ClienteAltaBaja
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.lbDNI = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.gbCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(57, 249);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(182, 249);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.rbC);
            this.gbCategoria.Controls.Add(this.rbB);
            this.gbCategoria.Controls.Add(this.rbA);
            this.gbCategoria.Location = new System.Drawing.Point(57, 163);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(200, 66);
            this.gbCategoria.TabIndex = 2;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria";
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(138, 30);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(32, 17);
            this.rbC.TabIndex = 2;
            this.rbC.TabStop = true;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(80, 30);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(32, 17);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(24, 30);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(32, 17);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(54, 53);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(26, 13);
            this.lbDNI.TabIndex = 3;
            this.lbDNI.Text = "DNI";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(54, 91);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(54, 129);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(52, 13);
            this.lbTelefono.TabIndex = 5;
            this.lbTelefono.Text = "Telefono:";
            // 
            // txbDNI
            // 
            this.txbDNI.Location = new System.Drawing.Point(157, 46);
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(100, 20);
            this.txbDNI.TabIndex = 6;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(157, 84);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 7;
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(157, 122);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(100, 20);
            this.txbTelefono.TabIndex = 8;
            // 
            // ClienteAltaBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 342);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbDNI);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbDNI);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Name = "ClienteAltaBaja";
            this.Text = "ClienteAltaBaja";
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.Label lbDNI;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox txbDNI;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbTelefono;
    }
}