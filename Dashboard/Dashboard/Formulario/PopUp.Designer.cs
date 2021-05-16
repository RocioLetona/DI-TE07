
namespace Dashboard.Formulario
{
    partial class PopUp
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
            this.tLP = new System.Windows.Forms.TableLayoutPanel();
            this.b_Cerrar = new System.Windows.Forms.Button();
            this.tB_Info = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP
            // 
            this.tLP.ColumnCount = 1;
            this.tLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP.Controls.Add(this.b_Cerrar, 0, 1);
            this.tLP.Controls.Add(this.tB_Info, 0, 0);
            this.tLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP.Location = new System.Drawing.Point(0, 0);
            this.tLP.Name = "tLP";
            this.tLP.RowCount = 2;
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.91304F));
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.08696F));
            this.tLP.Size = new System.Drawing.Size(431, 230);
            this.tLP.TabIndex = 0;
            // 
            // b_Cerrar
            // 
            this.b_Cerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b_Cerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.b_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.b_Cerrar, "Cierra la información sobre la empresa");
            this.b_Cerrar.Location = new System.Drawing.Point(3, 187);
            this.b_Cerrar.Name = "b_Cerrar";
            this.helpProvider1.SetShowHelp(this.b_Cerrar, true);
            this.b_Cerrar.Size = new System.Drawing.Size(425, 40);
            this.b_Cerrar.TabIndex = 0;
            this.b_Cerrar.Text = "Cerrar";
            this.b_Cerrar.UseVisualStyleBackColor = false;
            this.b_Cerrar.Click += new System.EventHandler(this.b_Cerrar_Click);
            // 
            // tB_Info
            // 
            this.tB_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tB_Info.Location = new System.Drawing.Point(3, 3);
            this.tB_Info.Multiline = true;
            this.tB_Info.Name = "tB_Info";
            this.tB_Info.ReadOnly = true;
            this.tB_Info.Size = new System.Drawing.Size(425, 163);
            this.tB_Info.TabIndex = 1;
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 230);
            this.Controls.Add(this.tLP);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUp";
            this.Text = "Información Empresa";
            this.Load += new System.EventHandler(this.PopUp_Load);
            this.tLP.ResumeLayout(false);
            this.tLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP;
        private System.Windows.Forms.Button b_Cerrar;
        private System.Windows.Forms.TextBox tB_Info;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}