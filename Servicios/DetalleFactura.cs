using System;
using System.Collections.Generic;

namespace N2_Taller_POO.Servicios
{
    class DetalleFactura
    {
        public int numeroFactura { get; set; }
        public int Cedula { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }

        public DetalleFactura(int numeroFactura, int Cedula, DateTime Fecha, double Total)
        {
            this.numeroFactura = numeroFactura;
            this.Cedula = Cedula;
            this.Fecha = Fecha;
            this.Total = Total;
        }
    }
}
