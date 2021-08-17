using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_Taller_POO.Servicios
{
    class Venta
    {
        public int numeroFactura { get; set; }
        public int codigoProducto { get; set; }
        public String nombreProducto { get; set; }
        public int cantidadProducto { get; set; }
        public double Total { get; set; }
        public Venta(int numeroFactura, int codigoProducto, String nombreProducto, int cantidadProducto, double Total)
        {
            this.numeroFactura = numeroFactura;
            this.codigoProducto = codigoProducto;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.Total = Total;
        }
        public Venta()
        {

        }
    }
}
