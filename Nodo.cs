using System;
using System.Collections.Generic;
using System.Text;

namespace ColaTransferenciasBancarias
{
    internal class Nodo
    {
        public Transferencia Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Transferencia dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
