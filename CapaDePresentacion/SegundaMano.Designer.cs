namespace CapaDePresentacion
{
    partial class SegundaMano
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lMatricula = new System.Windows.Forms.Label();
            this.lFechaMatriculacion = new System.Windows.Forms.Label();
            this.tbFechaMatriculacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lMatricula
            // 
            this.lMatricula.AutoSize = true;
            this.lMatricula.Location = new System.Drawing.Point(3, 9);
            this.lMatricula.Name = "lMatricula";
            this.lMatricula.Size = new System.Drawing.Size(53, 13);
            this.lMatricula.TabIndex = 1;
            this.lMatricula.Text = "Matricula:";
            // 
            // lFechaMatriculacion
            // 
            this.lFechaMatriculacion.AutoSize = true;
            this.lFechaMatriculacion.Location = new System.Drawing.Point(3, 52);
            this.lFechaMatriculacion.Name = "lFechaMatriculacion";
            this.lFechaMatriculacion.Size = new System.Drawing.Size(105, 13);
            this.lFechaMatriculacion.TabIndex = 3;
            this.lFechaMatriculacion.Text = "Fecha matriculación:";
            // 
            // tbFechaMatriculacion
            // 
            this.tbFechaMatriculacion.Location = new System.Drawing.Point(125, 49);
            this.tbFechaMatriculacion.Name = "tbFechaMatriculacion";
            this.tbFechaMatriculacion.Size = new System.Drawing.Size(100, 20);
            this.tbFechaMatriculacion.TabIndex = 2;
            // 
            // SegundaMano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lFechaMatriculacion);
            this.Controls.Add(this.tbFechaMatriculacion);
            this.Controls.Add(this.lMatricula);
            this.Controls.Add(this.textBox1);
            this.Name = "SegundaMano";
            this.Size = new System.Drawing.Size(229, 73);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lMatricula;
        private System.Windows.Forms.Label lFechaMatriculacion;
        private System.Windows.Forms.TextBox tbFechaMatriculacion;
    }
}
