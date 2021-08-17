using System;
using System.Collections.Generic;
using System.Linq;
using N2_Taller_POO;

namespace N2_Taller_POO.Servicios
{
    class Ventas
    {
        public int Cedula { get; set; }
        public DateTime Fecha { get; set; }
        public int codigoProducto{ get; set; }
        public int cantidadProducto { get; set; }
        public double Total { get; set; }
        
        public void VentaCliente(List<Cliente> ListaClientes, List<Producto> ListaProductos, List<Venta> VentaClientes, List<DetalleFactura> DetalleFacturas, List<Encabezado> Encabezados)
        {
            Cedula = 0;
            codigoProducto = 0;
            cantidadProducto = 0;
            Total = 0;

            ProductoServicio _productoServicio = new();
            DateTime now = DateTime.Now;
            Fecha = now;
            double totalVenta=0;
            var numeroFactura = new Random().Next(1, 1000);
            String respuesta;
            Console.Write($"--------------------\nGENERAR VENTA\nIngrese la cédula del cliente: ");
            try
            {
                Cedula = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite valores numéricos\nIngrese la cédula del cliente : ");
                Cedula = int.Parse(Console.ReadLine());
            }
            var verificarCliente = ListaClientes.Any(_cedula => _cedula.Cedula == Cedula);

            if (!verificarCliente)
            {
                while (!verificarCliente)
                {
                    Console.Write("No existe, digite nuevamente la cédula del cliente: ");
                    Cedula = int.Parse(Console.ReadLine());
                    verificarCliente = ListaClientes.Any(_cedula => _cedula.Cedula == Cedula);
                }
            }
            Console.WriteLine("-----------------------Lista de productos-----------------------");
            _productoServicio.ListarProductos(ListaProductos);

            do
            {
                Console.Write("--------------------\nGENERAR VENTA\nIngrese el código del producto que desea llevar: ");
                try
                {
                    codigoProducto = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Por favor, digite valores numéricos\nIngrese el código del producto que desea llevar: ");
                    codigoProducto = int.Parse(Console.ReadLine());
                }
                var verificarProducto = ListaProductos.Any(_producto => _producto.Codigo == codigoProducto);
                if (!verificarProducto)
                {
                    while (!verificarProducto)
                    {
                        Console.Write("No existe, ingrese el código del producto nuevamente: ");
                        codigoProducto = int.Parse(Console.ReadLine());
                        verificarProducto = ListaProductos.Any(_producto => _producto.Codigo == codigoProducto);
                    }
                }
                var consulta = ListaProductos.Where(codigo => codigo.Codigo == codigoProducto).FirstOrDefault();

                Console.Write($"Digite cantidad de {consulta.Nombre}: ");
                try
                {
                    cantidadProducto = int.Parse(Console.ReadLine());
                }catch(Exception)
                {
                    Console.Write($"Digite cantidad de {consulta.Nombre}: ");
                    cantidadProducto = int.Parse(Console.ReadLine());
                }
                if (consulta.Cantidad == 0)
                {
                    Console.WriteLine($"\nNo hay suficiente cantidad del producto, hay {consulta.Cantidad} de {consulta.Nombre}");
                }
                else
                {
                    while (cantidadProducto > consulta.Cantidad)
                    {
                        Console.WriteLine("\nExcede a la cantidad del producto");
                        Console.Write("Digite cantidad del producto: ");
                        cantidadProducto = int.Parse(Console.ReadLine());
                    }
                    consulta.Cantidad -= cantidadProducto;
                    totalVenta = consulta.Precio * cantidadProducto;
                    Total += totalVenta;
                    Venta venta1 = new Venta(numeroFactura, codigoProducto, consulta.Nombre ,cantidadProducto, totalVenta);
                    VentaClientes.Add(venta1);
                }
                
                Console.WriteLine("¿Desea hacer otra compra?");
                respuesta = Console.ReadLine();
            } while (respuesta.Equals("SI",  StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine("\n------------------------Factura---------------------");
            var consultaFactura = VentaClientes.Where(venta => venta.numeroFactura == numeroFactura).ToList();
            
            Console.WriteLine($"N° Factura: {numeroFactura}");
            Console.WriteLine($"Cédula: {Cedula}");
            foreach (var factura in consultaFactura)
            {
                Console.WriteLine($"Códido producto: {factura.codigoProducto} Producto: {factura.nombreProducto} Cantidad: {factura.cantidadProducto} Total: {factura.Total}");
            }
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Total: {Total}");
            Encabezado _encabezado = new(numeroFactura, Cedula, Total);
            Encabezados.Add(_encabezado);
            var _DetalleFactura = new DetalleFactura(numeroFactura, Cedula, Fecha, Total);
            DetalleFacturas.Add(_DetalleFactura);



        }
        
    }
}
