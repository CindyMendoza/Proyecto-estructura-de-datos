using System;
using System.Collections.Generic;
using System.Text;

namespace ColaTransferenciasBancarias
{
    internal class ColaTransferencias
    {
        private Nodo frente;
        private Nodo final;
        public int Cantidad { get; private set; }

        public bool EstaVacia()
        {
            return frente == null;
        }

        public void Encolar(Transferencia transferencia)
        {
            Nodo nuevo = new Nodo(transferencia);

            if (EstaVacia())
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.Siguiente = nuevo;
                final = nuevo;
            }

            Cantidad++;
        }

        public Transferencia Desencolar()
        {
            if (EstaVacia())
                return null;

            Transferencia dato = frente.Dato;
            frente = frente.Siguiente;
            Cantidad--;

            if (frente == null)
                final = null;

            return dato;
        }

        public IEnumerable<Transferencia> ObtenerTodas()
        {
            Nodo actual = frente;

            while (actual != null)
            {
                yield return actual.Dato;
                actual = actual.Siguiente;
            }
        }
    }
}
