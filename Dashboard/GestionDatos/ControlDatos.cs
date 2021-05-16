using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionDatos
{
    public class ControlDatos
    {
        public ControlDatos() { }

        public string LeerComercial(ComercialVO comercial, string[] datos)
        {
            int numeroCom = comercial.Numero;
            string datosCom = "";
            //leemos el array de string por lineas

            foreach (var linea in datos)
            {
                var valores = linea.Split(',');
                int columna_uno = int.Parse(valores[0]);
                if (columna_uno == numeroCom)
                {
                    datosCom = "Nombre: " + valores[1] + "\t\nApellido: " + valores[2] + 
                                "\t\nLocalidad: " + valores[3] + "\t\nEdad: " + valores[4];
                }
            }
            return datosCom;
        }

        public string LeerEmpresa(ComercialVO comercial, int numeroEmp, string[] datos)
        {
            //variables
            int numeroCom = comercial.Numero;
            string rdoEmpresa = null;
            int resultado= 0;

            //saltamos la primera línea del array
            datos = datos.Skip(1).ToArray();

            //leemos el nuevo array de string por lineas

            foreach (var linea in datos)
            {
                
                //introducimos cada línea en un nuevo array por la separación de las comas
                var valores = linea.Split(',');
                string uno = valores[0];
                string dos = valores[1];

                //guardamos en dos int el valor de la primera y segunda columna de la primera línea
                int columna_uno = int.Parse(uno);
                int columna_dos = int.Parse(dos);

                //si los int anteriores coinciden con el nº de comercial y el de empresa sumamos los datos de la línea
                if (columna_uno == numeroCom && columna_dos == numeroEmp)
                {
                    resultado = int.Parse(valores[2]) + int.Parse(valores[3]) + int.Parse(valores[4]) +
                                    int.Parse(valores[5]) + int.Parse(valores[6]) + int.Parse(valores[7]) + int.Parse(valores[8]) +
                                    int.Parse(valores[9]) + int.Parse(valores[10]) + int.Parse(valores[11]) + 
                                    int.Parse(valores[12]) + int.Parse(valores[13]);
                    
                }
                
                if (numeroCom == 0 && columna_dos == numeroEmp)
                {
                    resultado += int.Parse(valores[2]) + int.Parse(valores[3]) + int.Parse(valores[4]) +
                                    int.Parse(valores[5]) + int.Parse(valores[6]) + int.Parse(valores[7]) + int.Parse(valores[8]) +
                                    int.Parse(valores[9]) + int.Parse(valores[10]) + int.Parse(valores[11]) +
                                    int.Parse(valores[12]) + int.Parse(valores[13]);
                }

                rdoEmpresa = resultado.ToString();
            }
            return rdoEmpresa;
        }

        public Dictionary<string, int> LeerMensual(ComercialVO comercial, string[] datos)
        {
            //variables
            int numeroCom = comercial.Numero;
            int enero = 0, febrero = 0, marzo = 0, abril = 0, mayo = 0, junio = 0, julio = 0, agosto = 0, septiembre = 0,
                octubre = 0, noviembre = 0, diciembre = 0;
            string e, f, m, a, my, j, jl, ag, s, o, n, d;

            //Instanciamos el Dictionary que vamos a devolver
            Dictionary<string, int> rdoMensual = new Dictionary<string, int>();

            //leemos la primera línea del array y dividimos los elementos por las comas en un var (es un nuevo array)
            //se usaran para introducirlos en la key del dictionary
            var encabezado = datos[0].Split(',');

            //guardamos en string los datos de var encabezado para poder añadirlos al Dictionary
            e = encabezado[2].ToUpper();
            f = encabezado[3].ToUpper();
            m = encabezado[4].ToUpper();
            a = encabezado[5].ToUpper();
            my = encabezado[6].ToUpper();
            j = encabezado[7].ToUpper();
            jl = encabezado[8].ToUpper();
            ag = encabezado[9].ToUpper();
            s = encabezado[10].ToUpper();
            o = encabezado[11].ToUpper();
            n = encabezado[12].ToUpper();
            d = encabezado[13].ToUpper();

            //ahora guardamos el array saltando la primera línea para volver a leerlo línea a línea
            datos = datos.Skip(1).ToArray();

            //leemos el nuevo array de string por lineas

            foreach (var linea in datos)
            {
                //introducimos cada línea en un nuevo array por la separación de las comas
                var valores = linea.Split(',');
                //guardamos en un dato el valor de la primera columna de la primera línea
                int columna_uno = int.Parse(valores[0]);

                //si la primera columna coincide con el nº del comercial
                //vamos sumando los valores por cada columna para obtener el resultado de cada mes
                //luego se guardarán como valores del Dictionay
                if (columna_uno == numeroCom)
                {
                    enero += int.Parse(valores[2]);
                    febrero += int.Parse(valores[3]);
                    marzo += int.Parse(valores[4]);
                    abril += int.Parse(valores[5]);
                    mayo += int.Parse(valores[6]);
                    junio += int.Parse(valores[7]);
                    julio += int.Parse(valores[8]);
                    agosto += int.Parse(valores[9]);
                    septiembre += int.Parse(valores[10]);
                    octubre += int.Parse(valores[11]);
                    noviembre += int.Parse(valores[12]);
                    diciembre += int.Parse(valores[13]);

                }else if (numeroCom == 0){
                    enero += int.Parse(valores[2]);
                    febrero += int.Parse(valores[3]);
                    marzo += int.Parse(valores[4]);
                    abril += int.Parse(valores[5]);
                    mayo += int.Parse(valores[6]);
                    junio += int.Parse(valores[7]);
                    julio += int.Parse(valores[8]);
                    agosto += int.Parse(valores[9]);
                    septiembre += int.Parse(valores[10]);
                    octubre += int.Parse(valores[11]);
                    noviembre += int.Parse(valores[12]);
                    diciembre += int.Parse(valores[13]);
                }
            }

            //guardamos en el Dictionary las key y los valores
            rdoMensual.Add(e, enero);
            rdoMensual.Add(f, febrero);
            rdoMensual.Add(m, marzo);
            rdoMensual.Add(a, abril);
            rdoMensual.Add(my, mayo);
            rdoMensual.Add(j, junio);
            rdoMensual.Add(jl, julio);
            rdoMensual.Add(ag, agosto);
            rdoMensual.Add(s, septiembre);
            rdoMensual.Add(o, octubre);
            rdoMensual.Add(n, noviembre);
            rdoMensual.Add(d, diciembre);

            return rdoMensual;
        }
    }
}
