using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_Taller_POO.Servicios
{
    class ListarFacturas
    {
        public void Listar(List<Encabezado> Encabezados)
        {
            foreach (var factura in Encabezados)
            {
                Console.WriteLine($"N°Factura: {factura.numeroFactura} Cédula: {factura.cedula} Valor total: {factura.valorTotal}");
            }
        }
    }
}
