using DashboardDatos;
using DashboardManager;
using GestionDatos;
using System;
using System.Linq;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //DatosCom del Manager funciona
            Manager manager = new Manager();
            ComercialVO comercial = new ComercialVO(1);
            string data = manager.DatosCom(comercial);
            Console.WriteLine(data);
            //Si leo directamente los datos del DAL funciona
            AccesoDatos fichero = new AccesoDatos();
            string [] resultados = fichero.LeerFacturacion();
            resultados =resultados.Skip(1).ToArray();
            foreach (var linea in resultados)
            {
                //introducimos cada línea en un nuevo array por la separación de las comas
                var valores = linea.Split(',');
                Console.WriteLine(valores[0]);
                Console.WriteLine(valores[1]);
                /*foreach (var dato in valores)
                {
                    Console.WriteLine(dato);
                }*/
                string uno = valores[0];
                string dos = valores[1];
                //Console.WriteLine(valores[0]);
            }
                string empresa = manager.DatosEmp(comercial);
                //Console.WriteLine(resultados[0]);
            Console.WriteLine(empresa);
        }
    }
}
