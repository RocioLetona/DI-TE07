using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Formulario
{
    public partial class PopUp : Form
    {
        public PopUp(string texto)
        {
            InitializeComponent();
            this.tB_Info.Text = texto;
        }

        private void PopUp_Load(object sender, EventArgs e)
        {

        }

        private void b_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
