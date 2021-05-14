using Dashboard.ControUsuario;
using DashboardManager;
using GestionDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Formulario
{
    public partial class FormDashboard : Form
    {
        private TableLayoutPanel tlp;
        private DatosComerciales detalle;
        private Grafico grafico;
        private Empresa empresa;
        private TotalEmp total;
        private int numero;
        Manager manager = new Manager();

        public FormDashboard()
        {
            InitializeComponent();
            tlp = tLP_Datos;
            detalle = new ControUsuario.DatosComerciales();
            grafico = new ControUsuario.Grafico();
            empresa = new ControUsuario.Empresa();
            total = new ControUsuario.TotalEmp();
            this.toolTip1.SetToolTip(this.b_com1, "Click aquí para ver datos personales del comercial 1");
            this.toolTip1.SetToolTip(this.b_com2, "Click aquí para ver datos personales del comercial 2");
            this.toolTip1.SetToolTip(this.b_com3, "Click aquí para ver datos personales del comercial 3");
            this.toolTip1.SetToolTip(this.b_Total, "Click aquí para ver datos facturación anual empresa");
            this.toolTip1.SetToolTip(this.b_Empresa, "Click aquí para ver datos facturación por cliente en función de la selección de comercial o empresa");
            this.toolTip1.SetToolTip(this.b_Resultado, "Click aquí para ver datos facturación por meses en función de la selección de comercial o empresa");
        }

        //prueba con radio buttton, no se activan....
         public ComercialVO ElegirComercial()
        {
            ComercialVO comercialElegido = new ComercialVO(numero);
            return comercialElegido;
        }

        
        private void b_Resultado_Click(object sender, EventArgs e)
        {
            tlp.Controls.Remove(empresa);

            ComercialVO comercial = new ComercialVO(numero);
            Manager manager = new Manager();
            Dictionary<string, int> dic = manager.DatosMensual(comercial);
            //string key = "ENERO";

            //tB_comercial.Text = dic[key].ToString();

            foreach (KeyValuePair<string, int> d in dic)
            {
                grafico.c_mensual.Series["Series1"].Points.AddXY(d.Key, d.Value);
            }

            tlp.Controls.Add(grafico, 0, 1);
        }

        private void b_Empresa_Click(object sender, EventArgs e)
        {
            tlp.Controls.Remove(grafico);
            if (numero == 1 || numero == 2 || numero == 3)
            {
                ComercialVO comercial = new ComercialVO(numero);
                ComercialVO emp = new ComercialVO(0);
                Manager manager = new Manager();
                string[] datos = manager.DatosEmp(comercial);
                string[] datosEmp = manager.DatosEmp(emp);

                double totalCom = double.Parse(datos[2]);
                double totalEmp = double.Parse(datosEmp[2]);
                double porcentaje = (totalCom / totalEmp) * 100;
                double porcentajeRed = Math.Round(porcentaje, 2);

                empresa.tB_comEmp.Text = numero.ToString();
                empresa.tB_emp1.Text = datos[0];
                empresa.tB_emp2.Text = datos[1];
                empresa.tB_total.Text = datos[2];
                empresa.tB_porcentaje.Text = porcentajeRed.ToString();

                tlp.Controls.Add(empresa, 0, 1);

            }else if (numero == 0)
            {
                ComercialVO emp = new ComercialVO(numero);
                Manager manager = new Manager();
                string[] datosEmp = manager.DatosEmp(emp);

                double total1 = double.Parse(datosEmp[0]);
                double total2 = double.Parse(datosEmp[1]);
                double totalEmp = double.Parse(datosEmp[2]);
                double porcentaje1 = (total1 / totalEmp) * 100;
                double porcentaje2 = (total2 / totalEmp) * 100;
                double porcentajeRed1 = Math.Round(porcentaje1, 2);
                double porcentajeRed2 = Math.Round(porcentaje2, 2);

                total.c_totales.Titles["Title1"].Text = "Total facturado: " + totalEmp.ToString();
                total.c_totales.Series["Series1"].Points.AddXY("Empresa 1\n " + porcentajeRed1.ToString() + "%", total1);
                total.c_totales.Series["Series1"].Points.AddXY("Empresa 2\n " + porcentajeRed2.ToString() + "%", total2);
                
                tlp.Controls.Add(total, 0, 1);
            }
        }

        private void b_com1_Click_1(object sender, EventArgs e)
        {
            b_Empresa.Enabled = true;
            b_Resultado.Enabled = true;

            numero = 1;
            ComercialVO comercial = ElegirComercial();
            detalle.tB_detalle.Text = manager.DatosCom(comercial);

            tlp.Controls.Add(detalle, 1, 0);
        }

        private void b_com2_Click_1(object sender, EventArgs e)
        {
            b_Empresa.Enabled = true;
            b_Resultado.Enabled = true;

            numero = 2;
            ComercialVO comercial = ElegirComercial();
            detalle.tB_detalle.Text = manager.DatosCom(comercial);

            tlp.Controls.Add(detalle, 1, 0);
        }

        private void b_com3_Click(object sender, EventArgs e)
        {
            b_Empresa.Enabled = true;
            b_Resultado.Enabled = true;

            numero = 3;
            ComercialVO comercial = ElegirComercial();
            detalle.tB_detalle.Text = manager.DatosCom(comercial);

            tlp.Controls.Add(detalle, 1, 0);
        }

        private void b_Total_Click(object sender, EventArgs e)
        {
            b_Empresa.Enabled = true;
            b_Resultado.Enabled = true;

            numero = 0;

            detalle.tB_detalle.Text = "DESPEGANDO SL";

            tlp.Controls.Add(detalle, 1, 0);

        }

        private void b_Pop_Click(object sender, EventArgs e)
        {
            PopUp info = new PopUp("Aquí se muestra la información de creación, valores de la empresa y objetivos comerciales");
            info.Show();
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string appPath = Path.Combine(Application.StartupPath, "CHM\\Help.chm");
            Help.ShowHelp(this, appPath);
        }
    }
}
