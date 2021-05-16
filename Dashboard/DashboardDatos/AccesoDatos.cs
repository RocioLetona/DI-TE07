using System;
using System.IO;
using System.Linq;

namespace DashboardDatos
{
    public class AccesoDatos
    {
        /* ruta relativa que funciona con consola
         * private const string Datos1 = "../../../../1_datos_comerciales.csv";
        private const string Datos2 = "../../../../2_facturacion_comercial.csv";*/

        private const string Datos1 = "C:\\Users\\Rocio\\GIT\\DI TE07\\Dashboard\\1_datos_comerciales.csv";
        private const string Datos2 = "C:\\Users\\Rocio\\GIT\\DI TE07\\Dashboard\\2_facturacion_comercial.csv";


        public string[] datosCom;
        public string[] datosFact;

        public AccesoDatos() { }

        public string[] LeerComerciales()
        {
            try
            {
                //Recuperamos los datos del fichero csv y los guardamos en unarray de string
                datosCom = File.ReadAllLines(Datos1);

                //Saltamos la primera línea 
                datosCom = datosCom.Skip(1).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return datosCom;
        }

        public string[] LeerFacturacion()
        {
            try
            {
                //Recuperamos los datos del fichero csv y los guardamos en un array de string
                datosFact = File.ReadAllLines(Datos2);
                //Console.WriteLine(datosFact[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return datosFact;
        }
    }
}
