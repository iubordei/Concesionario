namespace CapaDePresentacion
{
    partial class Gestion
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
            this.menuStripGestion = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBajaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBusquedaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.vehículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAltaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBajaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBusquedaVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAltaPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBusquedaPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMostrarTodosPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDesconectar = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripGestion
            // 
            this.menuStripGestion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.vehículosToolStripMenuItem,
            this.presupuestosToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStripGestion.Location = new System.Drawing.Point(0, 0);
            this.menuStripGestion.Name = "menuStripGestion";
            this.menuStripGestion.Size = new System.Drawing.Size(800, 24);
            this.menuStripGestion.TabIndex = 0;
            this.menuStripGestion.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAltaCliente,
            this.tsBajaCliente,
            this.tsBusquedaCliente});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // tsAltaCliente
            // 
            this.tsAltaCliente.Name = "tsAltaCliente";
            this.tsAltaCliente.Size = new System.Drawing.Size(126, 22);
            this.tsAltaCliente.Text = "Alta";
            // 
            // tsBajaCliente
            // 
            this.tsBajaCliente.Name = "tsBajaCliente";
            this.tsBajaCliente.Size = new System.Drawing.Size(126, 22);
            this.tsBajaCliente.Text = "Baja";
            // 
            // tsBusquedaCliente
            // 
            this.tsBusquedaCliente.Name = "tsBusquedaCliente";
            this.tsBusquedaCliente.Size = new System.Drawing.Size(126, 22);
            this.tsBusquedaCliente.Text = "Búsqueda";
            // 
            // vehículosToolStripMenuItem
            // 
            this.vehículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAltaVehiculo,
            this.tsBajaVehiculo,
            this.tsBusquedaVehiculo});
            this.vehículosToolStripMenuItem.Name = "vehículosToolStripMenuItem";
            this.vehículosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.vehículosToolStripMenuItem.Text = "Vehículos";
            // 
            // tsAltaVehiculo
            // 
            this.tsAltaVehiculo.Name = "tsAltaVehiculo";
            this.tsAltaVehiculo.Size = new System.Drawing.Size(126, 22);
            this.tsAltaVehiculo.Text = "Alta";
            this.tsAltaVehiculo.Click += new System.EventHandler(this.tsAltaVehiculo_Click);
            // 
            // tsBajaVehiculo
            // 
            this.tsBajaVehiculo.Name = "tsBajaVehiculo";
            this.tsBajaVehiculo.Size = new System.Drawing.Size(126, 22);
            this.tsBajaVehiculo.Text = "Baja";
            this.tsBajaVehiculo.Click += new System.EventHandler(this.tsBajaVehiculo_Click);
            // 
            // tsBusquedaVehiculo
            // 
            this.tsBusquedaVehiculo.Name = "tsBusquedaVehiculo";
            this.tsBusquedaVehiculo.Size = new System.Drawing.Size(126, 22);
            this.tsBusquedaVehiculo.Text = "Búsqueda";
            // 
            // presupuestosToolStripMenuItem
            // 
            this.presupuestosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAltaPresupuesto,
            this.tsBusquedaPresupuesto,
            this.tsMostrarTodosPresupuesto});
            this.presupuestosToolStripMenuItem.Name = "presupuestosToolStripMenuItem";
            this.presupuestosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.presupuestosToolStripMenuItem.Text = "Presupuestos";
            // 
            // tsAltaPresupuesto
            // 
            this.tsAltaPresupuesto.Name = "tsAltaPresupuesto";
            this.tsAltaPresupuesto.Size = new System.Drawing.Size(149, 22);
            this.tsAltaPresupuesto.Text = "Alta";
            this.tsAltaPresupuesto.Click += new System.EventHandler(this.tsAltaPresupuesto_Click);
            // 
            // tsBusquedaPresupuesto
            // 
            this.tsBusquedaPresupuesto.Name = "tsBusquedaPresupuesto";
            this.tsBusquedaPresupuesto.Size = new System.Drawing.Size(149, 22);
            this.tsBusquedaPresupuesto.Text = "Búsqueda";
            this.tsBusquedaPresupuesto.Click += new System.EventHandler(this.tsBusquedaPresupuesto_Click);
            // 
            // tsMostrarTodosPresupuesto
            // 
            this.tsMostrarTodosPresupuesto.Name = "tsMostrarTodosPresupuesto";
            this.tsMostrarTodosPresupuesto.Size = new System.Drawing.Size(149, 22);
            this.tsMostrarTodosPresupuesto.Text = "Mostrar Todos";
            this.tsMostrarTodosPresupuesto.Click += new System.EventHandler(this.tsMostrarTodosPresupuesto_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDesconectar,
            this.salirToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // tsDesconectar
            // 
            this.tsDesconectar.Name = "tsDesconectar";
            this.tsDesconectar.Size = new System.Drawing.Size(181, 22);
            this.tsDesconectar.Text = "Desconectar usuario";
            this.tsDesconectar.Click += new System.EventHandler(this.tsDesconectar_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripGestion);
            this.MainMenuStrip = this.menuStripGestion;
            this.Name = "Gestion";
            this.Text = "Gestion";
            this.menuStripGestion.ResumeLayout(false);
            this.menuStripGestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripGestion;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsDesconectar;
        private System.Windows.Forms.ToolStripMenuItem tsAltaPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem tsBusquedaPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem tsAltaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsBajaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsBusquedaVehiculo;
        private System.Windows.Forms.ToolStripMenuItem tsAltaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsBajaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsBusquedaCliente;
        private System.Windows.Forms.ToolStripMenuItem tsMostrarTodosPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}