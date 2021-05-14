using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDatos
{
    public class ComercialVO
    {
        private int numero;

        public ComercialVO(int numero)
        {
            this.Numero = numero;
        }

        public int Numero { get => numero; set => numero = value; }
    }
}
