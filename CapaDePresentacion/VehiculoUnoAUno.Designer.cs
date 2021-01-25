namespace CapaDePresentacion
{
    partial class VehiculoUnoAUno
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiculoUnoAUno));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.lbAño = new System.Windows.Forms.Label();
            this.lPrecioRecomendado = new System.Windows.Forms.Label();
            this.tbPrecioRecomendado = new System.Windows.Forms.TextBox();
            this.lPotencia = new System.Windows.Forms.Label();
            this.tbPotencia = new System.Windows.Forms.TextBox();
            this.lModelo = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lMarca = new System.Windows.Forms.Label();
            this.lNumeroBastidor = new System.Windows.Forms.Label();
            this.tbNumeroBastidor = new System.Windows.Forms.TextBox();
            this.groupVehiculo = new System.Windows.Forms.GroupBox();
            this.rbSegundaMano = new System.Windows.Forms.RadioButton();
            this.rbNuevo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(610, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(MD.Vehiculo);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbAño
            // 
            this.tbAño.Location = new System.Drawing.Point(153, 254);
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(100, 20);
            this.tbAño.TabIndex = 26;
            // 
            // lbAño
            // 
            this.lbAño.AutoSize = true;
            this.lbAño.Location = new System.Drawing.Point(32, 257);
            this.lbAño.Name = "lbAño";
            this.lbAño.Size = new System.Drawing.Size(29, 13);
            this.lbAño.TabIndex = 25;
            this.lbAño.Text = "Año:";
            // 
            // lPrecioRecomendado
            // 
            this.lPrecioRecomendado.AutoSize = true;
            this.lPrecioRecomendado.Location = new System.Drawing.Point(29, 220);
            this.lPrecioRecomendado.Name = "lPrecioRecomendado";
            this.lPrecioRecomendado.Size = new System.Drawing.Size(108, 13);
            this.lPrecioRecomendado.TabIndex = 24;
            this.lPrecioRecomendado.Text = "Precio recomendado:";
            // 
            // tbPrecioRecomendado
            // 
            this.tbPrecioRecomendado.Location = new System.Drawing.Point(153, 217);
            this.tbPrecioRecomendado.Name = "tbPrecioRecomendado";
            this.tbPrecioRecomendado.Size = new System.Drawing.Size(100, 20);
            this.tbPrecioRecomendado.TabIndex = 23;
            // 
            // lPotencia
            // 
            this.lPotencia.AutoSize = true;
            this.lPotencia.Location = new System.Drawing.Point(29, 176);
            this.lPotencia.Name = "lPotencia";
            this.lPotencia.Size = new System.Drawing.Size(52, 13);
            this.lPotencia.TabIndex = 22;
            this.lPotencia.Text = "Potencia:";
            // 
            // tbPotencia
            // 
            this.tbPotencia.Location = new System.Drawing.Point(153, 173);
            this.tbPotencia.Name = "tbPotencia";
            this.tbPotencia.Size = new System.Drawing.Size(100, 20);
            this.tbPotencia.TabIndex = 21;
            // 
            // lModelo
            // 
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(29, 135);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(45, 13);
            this.lModelo.TabIndex = 20;
            this.lModelo.Text = "Modelo:";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(153, 132);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(100, 20);
            this.tbModelo.TabIndex = 19;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(153, 93);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 20);
            this.tbMarca.TabIndex = 18;
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(29, 93);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(40, 13);
            this.lMarca.TabIndex = 17;
            this.lMarca.Text = "Marca:";
            // 
            // lNumeroBastidor
            // 
            this.lNumeroBastidor.AutoSize = true;
            this.lNumeroBastidor.Location = new System.Drawing.Point(29, 55);
            this.lNumeroBastidor.Name = "lNumeroBastidor";
            this.lNumeroBastidor.Size = new System.Drawing.Size(103, 13);
            this.lNumeroBastidor.TabIndex = 16;
            this.lNumeroBastidor.Text = "Número de Bastidor:";
            // 
            // tbNumeroBastidor
            // 
            this.tbNumeroBastidor.Location = new System.Drawing.Point(153, 52);
            this.tbNumeroBastidor.Name = "tbNumeroBastidor";
            this.tbNumeroBastidor.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroBastidor.TabIndex = 15;
            // 
            // groupVehiculo
            // 
            this.groupVehiculo.Controls.Add(this.rbSegundaMano);
            this.groupVehiculo.Controls.Add(this.rbNuevo);
            this.groupVehiculo.Location = new System.Drawing.Point(352, 55);
            this.groupVehiculo.Name = "groupVehiculo";
            this.groupVehiculo.Size = new System.Drawing.Size(228, 100);
            this.groupVehiculo.TabIndex = 27;
            this.groupVehiculo.TabStop = false;
            this.groupVehiculo.Text = "Vehiculo";
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
            // 
            // VehiculoUnoAUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 302);
            this.Controls.Add(this.groupVehiculo);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.lbAño);
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
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "VehiculoUnoAUno";
            this.Text = "Datos de un vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupVehiculo.ResumeLayout(false);
            this.groupVehiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.Label lbAño;
        private System.Windows.Forms.Label lPrecioRecomendado;
        private System.Windows.Forms.TextBox tbPrecioRecomendado;
        private System.Windows.Forms.Label lPotencia;
        private System.Windows.Forms.TextBox tbPotencia;
        private System.Windows.Forms.Label lModelo;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.Label lNumeroBastidor;
        private System.Windows.Forms.TextBox tbNumeroBastidor;
        private System.Windows.Forms.GroupBox groupVehiculo;
        private System.Windows.Forms.RadioButton rbSegundaMano;
        private System.Windows.Forms.RadioButton rbNuevo;
    }
}