
namespace Dashboard.ControUsuario
{
    partial class DatosComerciales
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
            this.tB_detalle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tB_detalle
            // 
            this.tB_detalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tB_detalle.Cursor = System.Windows.Forms.Cursors.Default;
            this.tB_detalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_detalle.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_detalle.Location = new System.Drawing.Point(0, 0);
            this.tB_detalle.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tB_detalle.Multiline = true;
            this.tB_detalle.Name = "tB_detalle";
            this.tB_detalle.ReadOnly = true;
            this.tB_detalle.Size = new System.Drawing.Size(1672, 77);
            this.tB_detalle.TabIndex = 0;
            this.tB_detalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DatosComerciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tB_detalle);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DatosComerciales";
            this.Size = new System.Drawing.Size(1672, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tB_detalle;
    }
}
