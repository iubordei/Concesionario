namespace CapaDePresentacion
{
    partial class Nuevo
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
            this.lExtras = new System.Windows.Forms.Label();
            this.lbExtras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lExtras
            // 
            this.lExtras.AutoSize = true;
            this.lExtras.Location = new System.Drawing.Point(3, 37);
            this.lExtras.Name = "lExtras";
            this.lExtras.Size = new System.Drawing.Size(39, 13);
            this.lExtras.TabIndex = 0;
            this.lExtras.Text = "Extras:";
            // 
            // lbExtras
            // 
            this.lbExtras.FormattingEnabled = true;
            this.lbExtras.Items.AddRange(new object[] {
            "Pintura metalizada",
            "Llantas especiales",
            "Asientos calefactables",
            "Techo solar"});
            this.lbExtras.Location = new System.Drawing.Point(65, 26);
            this.lbExtras.Name = "lbExtras";
            this.lbExtras.Size = new System.Drawing.Size(120, 69);
            this.lbExtras.TabIndex = 1;
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbExtras);
            this.Controls.Add(this.lExtras);
            this.Name = "Nuevo";
            this.Size = new System.Drawing.Size(199, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lExtras;
        private System.Windows.Forms.ListBox lbExtras;
    }
}
