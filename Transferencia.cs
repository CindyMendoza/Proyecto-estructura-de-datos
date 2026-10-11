using System;
using System.Collections.Generic;
using System.Text;

namespace ColaTransferenciasBancarias
{
    internal class Transferencia
    {
        public string Id { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public decimal Monto { get; set; }

        public Transferencia(string id, string origen,
            string destino, decimal monto)
        {
            Id = id;
            Origen = origen;
            Destino = destino;
            Monto = monto;
        }

        public override string ToString()
        {
            return $"{Id} | {Origen} → {Destino} | S/ {Monto:N2}";
        }
    }
}


