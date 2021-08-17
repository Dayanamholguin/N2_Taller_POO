using System;
using System.Collections.Generic;
using System.Linq;

namespace N2_Taller_POO.Servicios
{
    class BuscarFactura
    {
        public void BuscarDetalleFactura(List<Venta> VentaClientes, List<DetalleFactura> DetalleFacturas)
        {
            Console.Write("Digite número de factura que va a buscar: ");
            int numeroFactura;
            try
            {
                numeroFactura = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Digite valores numéricos\nDigite número de factura que va a buscar: ");
                numeroFactura = int.Parse(Console.ReadLine());
            }
            while (!ValidarFactura(numeroFactura, DetalleFacturas))
            {
                Console.Write("\nEse número de factura no existe,\nDigite número de factura: ");
                numeroFactura = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n------------------------Detalle Factura---------------------");
            var consultaFactura1 = DetalleFacturas.Where(_detalle => _detalle.numeroFactura == numeroFactura).ToList();
            foreach (var detalle in consultaFactura1)
            {
                Console.WriteLine("N° Factura: " + detalle.numeroFactura + " \nCédula: " + detalle.Cedula + " \nFecha: " + detalle.Fecha + "\nTotal: "+detalle.Total);
            }

            var consultaFactura = VentaClientes.Where(venta => venta.numeroFactura == numeroFactura).ToList();
            foreach (var factura in consultaFactura)
            {
                Console.WriteLine($"Código del producto: {factura.codigoProducto} -- Producto: {factura.nombreProducto} -- Cantidad: {factura.cantidadProducto} -- Total: {factura.Total}");
            }
        }
        private bool ValidarFactura(int numero, List<DetalleFactura> DetalleFacturas)
        {
            foreach (var producto in DetalleFacturas)
            {
                if (producto.numeroFactura == numero) return true;
            }
            return false;
        }
    }
}
