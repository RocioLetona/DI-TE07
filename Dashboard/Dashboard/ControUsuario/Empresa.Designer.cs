
namespace Dashboard.ControUsuario
{
    partial class Empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresa));
            this.tLP_empresa = new System.Windows.Forms.TableLayoutPanel();
            this.l_porcentaje = new System.Windows.Forms.Label();
            this.l_total = new System.Windows.Forms.Label();
            this.tB_emp2 = new System.Windows.Forms.TextBox();
            this.tB_emp1 = new System.Windows.Forms.TextBox();
            this.l_com = new System.Windows.Forms.Label();
            this.l_emp2 = new System.Windows.Forms.Label();
            this.l_emp1 = new System.Windows.Forms.Label();
            this.tB_comEmp = new System.Windows.Forms.TextBox();
            this.tB_total = new System.Windows.Forms.TextBox();
            this.tB_porcentaje = new System.Windows.Forms.TextBox();
            this.tLP_empresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_empresa
            // 
            this.tLP_empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.tLP_empresa, "tLP_empresa");
            this.tLP_empresa.Controls.Add(this.l_porcentaje, 0, 4);
            this.tLP_empresa.Controls.Add(this.l_total, 0, 3);
            this.tLP_empresa.Controls.Add(this.tB_emp2, 1, 2);
            this.tLP_empresa.Controls.Add(this.tB_emp1, 1, 1);
            this.tLP_empresa.Controls.Add(this.l_com, 0, 0);
            this.tLP_empresa.Controls.Add(this.l_emp2, 0, 2);
            this.tLP_empresa.Controls.Add(this.l_emp1, 0, 1);
            this.tLP_empresa.Controls.Add(this.tB_comEmp, 1, 0);
            this.tLP_empresa.Controls.Add(this.tB_total, 1, 3);
            this.tLP_empresa.Controls.Add(this.tB_porcentaje, 1, 4);
            this.tLP_empresa.Name = "tLP_empresa";
            // 
            // l_porcentaje
            // 
            resources.ApplyResources(this.l_porcentaje, "l_porcentaje");
            this.l_porcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.l_porcentaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_porcentaje.Name = "l_porcentaje";
            // 
            // l_total
            // 
            resources.ApplyResources(this.l_total, "l_total");
            this.l_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.l_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_total.Name = "l_total";
            // 
            // tB_emp2
            // 
            resources.ApplyResources(this.tB_emp2, "tB_emp2");
            this.tB_emp2.Name = "tB_emp2";
            this.tB_emp2.ReadOnly = true;
            // 
            // tB_emp1
            // 
            resources.ApplyResources(this.tB_emp1, "tB_emp1");
            this.tB_emp1.Name = "tB_emp1";
            this.tB_emp1.ReadOnly = true;
            // 
            // l_com
            // 
            resources.ApplyResources(this.l_com, "l_com");
            this.l_com.BackColor = System.Drawing.Color.Teal;
            this.l_com.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_com.Name = "l_com";
            // 
            // l_emp2
            // 
            resources.ApplyResources(this.l_emp2, "l_emp2");
            this.l_emp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.l_emp2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_emp2.Name = "l_emp2";
            // 
            // l_emp1
            // 
            resources.ApplyResources(this.l_emp1, "l_emp1");
            this.l_emp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.l_emp1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_emp1.Name = "l_emp1";
            // 
            // tB_comEmp
            // 
            resources.ApplyResources(this.tB_comEmp, "tB_comEmp");
            this.tB_comEmp.Name = "tB_comEmp";
            this.tB_comEmp.ReadOnly = true;
            // 
            // tB_total
            // 
            resources.ApplyResources(this.tB_total, "tB_total");
            this.tB_total.Name = "tB_total";
            this.tB_total.ReadOnly = true;
            // 
            // tB_porcentaje
            // 
            resources.ApplyResources(this.tB_porcentaje, "tB_porcentaje");
            this.tB_porcentaje.Name = "tB_porcentaje";
            this.tB_porcentaje.ReadOnly = true;
            // 
            // Empresa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tLP_empresa);
            this.Name = "Empresa";
            this.tLP_empresa.ResumeLayout(false);
            this.tLP_empresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_empresa;
        private System.Windows.Forms.Label l_com;
        private System.Windows.Forms.Label l_emp2;
        private System.Windows.Forms.Label l_emp1;
        public System.Windows.Forms.TextBox tB_emp2;
        public System.Windows.Forms.TextBox tB_emp1;
        public System.Windows.Forms.TextBox tB_comEmp;
        private System.Windows.Forms.Label l_total;
        public System.Windows.Forms.TextBox tB_total;
        private System.Windows.Forms.Label l_porcentaje;
        public System.Windows.Forms.TextBox tB_porcentaje;
    }
}
