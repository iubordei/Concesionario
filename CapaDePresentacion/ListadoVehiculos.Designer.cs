namespace CapaDePresentacion
{
    partial class ListadoVehiculos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNumeroBastidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPotencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNumeroBastidor,
            this.cMarca,
            this.cModelo,
            this.cPotencia,
            this.cPrecio,
            this.cAño,
            this.cMatricula,
            this.cFecha,
            this.cExtras});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // cNumeroBastidor
            // 
            this.cNumeroBastidor.HeaderText = "Número de bastidor";
            this.cNumeroBastidor.Name = "cNumeroBastidor";
            // 
            // cMarca
            // 
            this.cMarca.HeaderText = "Marca";
            this.cMarca.Name = "cMarca";
            // 
            // cModelo
            // 
            this.cModelo.HeaderText = "Modelo";
            this.cModelo.Name = "cModelo";
            // 
            // cPotencia
            // 
            this.cPotencia.HeaderText = "Potencia";
            this.cPotencia.Name = "cPotencia";
            // 
            // cPrecio
            // 
            this.cPrecio.HeaderText = "Precio recomendado";
            this.cPrecio.Name = "cPrecio";
            // 
            // cAño
            // 
            this.cAño.HeaderText = "Año";
            this.cAño.Name = "cAño";
            // 
            // cMatricula
            // 
            this.cMatricula.HeaderText = "Matricula";
            this.cMatricula.Name = "cMatricula";
            // 
            // cFecha
            // 
            this.cFecha.HeaderText = "Fecha de matriculación";
            this.cFecha.Name = "cFecha";
            // 
            // cExtras
            // 
            this.cExtras.HeaderText = "Número de extras";
            this.cExtras.Name = "cExtras";
            // 
            // ListadoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(796, 192);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListadoVehiculos";
            this.Text = " Listado de Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroBastidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPotencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cExtras;
    }
}