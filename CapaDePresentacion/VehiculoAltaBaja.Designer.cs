namespace CapaDePresentacion
{
    partial class VehiculoAltaBaja
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
            this.tbNumeroBastidor = new System.Windows.Forms.TextBox();
            this.lNumeroBastidor = new System.Windows.Forms.Label();
            this.lMarca = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lModelo = new System.Windows.Forms.Label();
            this.lPotencia = new System.Windows.Forms.Label();
            this.tbPotencia = new System.Windows.Forms.TextBox();
            this.lPrecioRecomendado = new System.Windows.Forms.Label();
            this.tbPrecioRecomendado = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.groupVehiculo = new System.Windows.Forms.GroupBox();
            this.rbNuevo = new System.Windows.Forms.RadioButton();
            this.rbSegundaMano = new System.Windows.Forms.RadioButton();
            this.groupVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNumeroBastidor
            // 
            this.tbNumeroBastidor.Location = new System.Drawing.Point(176, 50);
            this.tbNumeroBastidor.Name = "tbNumeroBastidor";
            this.tbNumeroBastidor.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroBastidor.TabIndex = 0;
            // 
            // lNumeroBastidor
            // 
            this.lNumeroBastidor.AutoSize = true;
            this.lNumeroBastidor.Location = new System.Drawing.Point(52, 53);
            this.lNumeroBastidor.Name = "lNumeroBastidor";
            this.lNumeroBastidor.Size = new System.Drawing.Size(103, 13);
            this.lNumeroBastidor.TabIndex = 1;
            this.lNumeroBastidor.Text = "Número de Bastidor:";
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(52, 91);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(40, 13);
            this.lMarca.TabIndex = 2;
            this.lMarca.Text = "Marca:";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(176, 91);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 3;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(176, 130);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(100, 20);
            this.tbModelo.TabIndex = 4;
            // 
            // lModelo
            // 
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(52, 133);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(45, 13);
            this.lModelo.TabIndex = 5;
            this.lModelo.Text = "Modelo:";
            // 
            // lPotencia
            // 
            this.lPotencia.AutoSize = true;
            this.lPotencia.Location = new System.Drawing.Point(52, 174);
            this.lPotencia.Name = "lPotencia";
            this.lPotencia.Size = new System.Drawing.Size(52, 13);
            this.lPotencia.TabIndex = 7;
            this.lPotencia.Text = "Potencia:";
            // 
            // tbPotencia
            // 
            this.tbPotencia.Location = new System.Drawing.Point(176, 171);
            this.tbPotencia.Name = "tbPotencia";
            this.tbPotencia.Size = new System.Drawing.Size(100, 20);
            this.tbPotencia.TabIndex = 6;
            // 
            // lPrecioRecomendado
            // 
            this.lPrecioRecomendado.AutoSize = true;
            this.lPrecioRecomendado.Location = new System.Drawing.Point(52, 218);
            this.lPrecioRecomendado.Name = "lPrecioRecomendado";
            this.lPrecioRecomendado.Size = new System.Drawing.Size(108, 13);
            this.lPrecioRecomendado.TabIndex = 9;
            this.lPrecioRecomendado.Text = "Precio recomendado:";
            // 
            // tbPrecioRecomendado
            // 
            this.tbPrecioRecomendado.Location = new System.Drawing.Point(176, 215);
            this.tbPrecioRecomendado.Name = "tbPrecioRecomendado";
            this.tbPrecioRecomendado.Size = new System.Drawing.Size(100, 20);
            this.tbPrecioRecomendado.TabIndex = 8;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(201, 314);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 10;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(390, 314);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // groupVehiculo
            // 
            this.groupVehiculo.Controls.Add(this.rbSegundaMano);
            this.groupVehiculo.Controls.Add(this.rbNuevo);
            this.groupVehiculo.Location = new System.Drawing.Point(390, 37);
            this.groupVehiculo.Name = "groupVehiculo";
            this.groupVehiculo.Size = new System.Drawing.Size(228, 100);
            this.groupVehiculo.TabIndex = 12;
            this.groupVehiculo.TabStop = false;
            this.groupVehiculo.Text = "Vehiculo";
            // 
            // rbNuevo
            // 
            this.rbNuevo.AutoSize = true;
            this.rbNuevo.Location = new System.Drawing.Point(18, 49);
            this.rbNuevo.Name = "rbNuevo";
            this.rbNuevo.Size = new System.Drawing.Size(57, 17);
            this.rbNuevo.TabIndex = 0;
            this.rbNuevo.TabStop = true;
            this.rbNuevo.Text = "Nuevo";
            this.rbNuevo.UseVisualStyleBackColor = true;
            this.rbNuevo.CheckedChanged += new System.EventHandler(this.rbNuevo_CheckedChanged);
            // 
            // rbSegundaMano
            // 
            this.rbSegundaMano.AutoSize = true;
            this.rbSegundaMano.Location = new System.Drawing.Point(124, 49);
            this.rbSegundaMano.Name = "rbSegundaMano";
            this.rbSegundaMano.Size = new System.Drawing.Size(97, 17);
            this.rbSegundaMano.TabIndex = 1;
            this.rbSegundaMano.TabStop = true;
            this.rbSegundaMano.Text = "Segunda mano";
            this.rbSegundaMano.UseVisualStyleBackColor = true;
            this.rbSegundaMano.CheckedChanged += new System.EventHandler(this.rbSegundaMano_CheckedChanged);
            // 
            // VehiculoAltaBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 355);
            this.Controls.Add(this.groupVehiculo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lPrecioRecomendado);
            this.Controls.Add(this.tbPrecioRecomendado);
            this.Controls.Add(this.lPotencia);
            this.Controls.Add(this.tbPotencia);
            this.Controls.Add(this.lModelo);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.lNumeroBastidor);
            this.Controls.Add(this.tbNumeroBastidor);
            this.Name = "VehiculoAltaBaja";
            this.Text = "VehiculoAltaBaja";
            this.groupVehiculo.ResumeLayout(false);
            this.groupVehiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumeroBastidor;
        private System.Windows.Forms.Label lNumeroBastidor;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label lModelo;
        private System.Windows.Forms.Label lPotencia;
        private System.Windows.Forms.TextBox tbPotencia;
        private System.Windows.Forms.Label lPrecioRecomendado;
        private System.Windows.Forms.TextBox tbPrecioRecomendado;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.GroupBox groupVehiculo;
        private System.Windows.Forms.RadioButton rbSegundaMano;
        private System.Windows.Forms.RadioButton rbNuevo;
    }
}