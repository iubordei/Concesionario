
namespace CapaDePresentacion
{
    partial class PresupuestoListado
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
            this.dataGridPresupuesto = new System.Windows.Forms.DataGridView();
            this.presupuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRealizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPresupuesto
            // 
            this.dataGridPresupuesto.AllowUserToAddRows = false;
            this.dataGridPresupuesto.AllowUserToDeleteRows = false;
            this.dataGridPresupuesto.AutoGenerateColumns = false;
            this.dataGridPresupuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteDataGridViewTextBoxColumn,
            this.vehiculoDataGridViewTextBoxColumn,
            this.fechaRealizacionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.valoracionDataGridViewTextBoxColumn});
            this.dataGridPresupuesto.DataSource = this.presupuestoBindingSource;
            this.dataGridPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPresupuesto.Location = new System.Drawing.Point(0, 0);
            this.dataGridPresupuesto.Name = "dataGridPresupuesto";
            this.dataGridPresupuesto.ReadOnly = true;
            this.dataGridPresupuesto.Size = new System.Drawing.Size(800, 450);
            this.dataGridPresupuesto.TabIndex = 0;
            // 
            // presupuestoBindingSource
            // 
            this.presupuestoBindingSource.DataSource = typeof(MD.Presupuesto);
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehiculoDataGridViewTextBoxColumn
            // 
            this.vehiculoDataGridViewTextBoxColumn.DataPropertyName = "Vehiculo";
            this.vehiculoDataGridViewTextBoxColumn.HeaderText = "Vehiculo";
            this.vehiculoDataGridViewTextBoxColumn.Name = "vehiculoDataGridViewTextBoxColumn";
            this.vehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRealizacionDataGridViewTextBoxColumn
            // 
            this.fechaRealizacionDataGridViewTextBoxColumn.DataPropertyName = "FechaRealizacion";
            this.fechaRealizacionDataGridViewTextBoxColumn.HeaderText = "FechaRealizacion";
            this.fechaRealizacionDataGridViewTextBoxColumn.Name = "fechaRealizacionDataGridViewTextBoxColumn";
            this.fechaRealizacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoracionDataGridViewTextBoxColumn
            // 
            this.valoracionDataGridViewTextBoxColumn.DataPropertyName = "Valoracion";
            this.valoracionDataGridViewTextBoxColumn.HeaderText = "Valoracion";
            this.valoracionDataGridViewTextBoxColumn.Name = "valoracionDataGridViewTextBoxColumn";
            this.valoracionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(800, 450);
            this.dataGrid.TabIndex = 1;
            // 
            // PresupuestoListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.dataGridPresupuesto);
            this.Name = "PresupuestoListado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.PresupuestoListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presupuestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPresupuesto;
        private System.Windows.Forms.BindingSource presupuestoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRealizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}