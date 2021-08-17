using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_Taller_POO.Servicios
{
    class Encabezado
    {
        public int numeroFactura { get; set; }
        public int cedula { get; set; }
        public double valorTotal { get; set; }
        public Encabezado(int numeroFactura, int cedula, double valorTotal)
        {
            this.numeroFactura = numeroFactura;
            this.cedula = cedula;
            this.valorTotal = valorTotal;
        }
    }
}
