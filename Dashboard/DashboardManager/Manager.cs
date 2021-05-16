using System;
using System.Collections.Generic;
using System.Text;
using DashboardDatos;
using GestionDatos;

namespace DashboardManager
{
    public class Manager
    {
        public Manager() { }

        public string DatosCom(ComercialVO comercial)
        {
            //Aceedemos a los datos de DAL
            AccesoDatos fichero = new AccesoDatos();
            var datos = fichero.LeerComerciales();

            //Realizamos operaciones para obtener retorno
            ControlDatos lectura = new ControlDatos();
            string datosCom = lectura.LeerComercial(comercial, datos);

            return datosCom;
        }

        public string [] DatosEmp(ComercialVO comercial)
        {
            string[] facturacionAnual = new string[3];

            //Aceedemos a los datos de DAL
            AccesoDatos fichero = new AccesoDatos();
            string[] datos = fichero.LeerFacturacion();

            //Realizamos operaciones para obtener retorno
            ControlDatos lectura = new ControlDatos();
            string empresa_1 = lectura.LeerEmpresa(comercial, 1, datos);
            string empresa_2 = lectura.LeerEmpresa(comercial, 2, datos);

            int total = int.Parse(empresa_1) + int.Parse(empresa_2);

            facturacionAnual[0]= empresa_1;
            facturacionAnual[1]= empresa_2;
            facturacionAnual[2] = total.ToString();

            return facturacionAnual;
        }

        public Dictionary<string, int> DatosMensual(ComercialVO comercial)
        {
            //Aceedemos a los datos de DAL
            AccesoDatos fichero = new AccesoDatos();
            string[] datos = fichero.LeerFacturacion();

            ControlDatos lectura = new ControlDatos();


            //Instanciamos el Dictionary que vamos a devolver
            Dictionary<string, int> rdoMensual = lectura.LeerMensual(comercial, datos);

            return rdoMensual;
        }
    }
}
