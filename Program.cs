using N2_Taller_POO.Servicios;
using System;
using System.Collections.Generic;

namespace N2_Taller_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteServicio _clienteServicio = new();
            ProductoServicio _productoServicio = new();
            BuscarFactura _buscarFactura = new();
            Ventas _ventas = new();
            List<Cliente> ListaClientes = new List<Cliente>();
            List<Producto> ListaProductos = new List<Producto>();
            List<Venta> VentaClientes = new List<Venta>();
            List<Encabezado> Encabezados = new();
            ListarFacturas _listarFacturas = new();
            List<DetalleFactura> DetalleFacturas = new List<DetalleFactura>();
            int respuesta;
            String NombreEmpresa = "Por defecto";
            Console.WriteLine($"\n-----Menu Principal {NombreEmpresa}-----\n¿Qué opción desea elegir?: \nModulo1: Clientes\nModulo2: Productos\nModulo3: Ventas\nModulo4: Reportes\nModulo5: Configuración\nSalir del programa(Cualquier otro número) ");
            try
            {
                respuesta = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine($"\n¡DIGITE UN NÚMERO!\n-----Menu Principal  {NombreEmpresa}-----\n¿Qué opción desea elegir?: \nModulo1: Clientes\nModulo2: Productos\nModulo3: Ventas\nModulo4: Reportes\nModulo5: Configuración\nSalir del programa(Cualquier otro número) ");
                respuesta = int.Parse(Console.ReadLine());
            }            
            while (respuesta >= 1 && respuesta <= 5)
            {
                switch (respuesta)
                {
                    case 1:
                        Console.WriteLine("\n-----Módulo Cliente-----\n¿Qué desea elegir?: \n1. Crear \n2. Buscar \n3. Modificar \n4. Eliminar \nVolver(Cualquier otro número)");
                        try
                        {
                            respuesta = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\n¡DIGITE UN NÚMERO!\n-----Módulo Cliente-----\n¿Qué desea elegir?: \n1. Crear \n2. Buscar \n3. Modificar \n4. Eliminar \nVolver(Cualquier otro número)");
                            respuesta = int.Parse(Console.ReadLine());
                        }
                        while (respuesta >= 1 && respuesta <= 4)
                        {
                            switch (respuesta)
                            {
                                case 1:
                                    _clienteServicio.Crear(ListaClientes);
                                    break;
                                case 2:
                                    _clienteServicio.Buscar(ListaClientes);
                                    break;
                                case 3:
                                    _clienteServicio.Editar(ListaClientes);
                                    break;
                                case 4:
                                    _clienteServicio.Eliminar(ListaClientes);
                                    break;
                                default:
                                    break;
                            }
                            Console.WriteLine("\n-----Módulo Cliente-----\n¿Qué desea elegir?: \n1. Crear \n2. Buscar \n3. Modificar \n4. Eliminar \nVolver(Cualquier otro número)");
                            try
                            {
                                respuesta = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\n¡DIGITE UN NÚMERO!\n-----Módulo Cliente-----\n¿Qué desea elegir?: \n1. Crear \n2. Buscar \n3. Modificar \n4. Eliminar \nVolver(Cualquier otro número)");
                                respuesta = int.Parse(Console.ReadLine());
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n-----Módulo Producto-----\n¿Qué desea elegir?: \n1. Crear \n2. Buscar \n3. Modificar \n4. Eliminar \nVolver(Cualquier otro número)");
                        try
                        {
                            respuesta = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\n¡DIGITE UN NÚMERO!\n-----Módulo Producto-----\n¿Qué desea elegir?: \n1. Crear \n2. Buscar \n3. Modificar \n4. Eliminar \nVolver(Cualquier otro número)");
                            respuesta = int.Parse(Console.ReadLine());
                        }
                        while (respuesta >= 1 && respuesta <= 4)
                        {
                            switch (respuesta)
                            {
                                case 1:
                                    _productoServicio.Crear(ListaProductos);
                                    break;
                                case 2:
                                    _productoServicio.Buscar(ListaProductos);
                                    break;
                                case 3:
                                    _productoServicio.Editar(ListaProductos);
                                    break;
                                case 4:
                                    _productoServicio.Eliminar(ListaProductos);
                                    break;
                                default:
                                    break;
                            }
                            Console.WriteLine("\n-----Módulo Producto-----\n¿Qué desea elegir?: \n1. Crear \n2. Buscar \n3. Modificar \n4. Eliminar \nVolver(Cualquier otro número)");
                            try
                            {
                                respuesta = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\n¡DIGITE UN NÚMERO!\n-----Módulo Producto-----\n¿Qué desea elegir?: \n1. Crear \n2. Buscar \n3. Modificar \n4. Eliminar \nVolver(Cualquier otro número)");
                                respuesta = int.Parse(Console.ReadLine());
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n-----Módulo Ventas-----\n¿Qué desea elegir?: \n1. Realizar venta \n2. Buscar factura \nVolver(Cualquier otro número)");
                        try
                        {
                            respuesta = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\n-----Módulo Ventas-----\n¿Qué desea elegir?: \n1. Realizar venta \n2. Buscar factura \nVolver(Cualquier otro número)"); 
                            respuesta = int.Parse(Console.ReadLine());
                        }
                        while (respuesta >= 1 && respuesta <= 2)
                        {
                            switch (respuesta)
                            {
                                case 1:
                                    _ventas.VentaCliente(ListaClientes, ListaProductos, VentaClientes, DetalleFacturas, Encabezados);
                                    break;
                                case 2:
                                    _buscarFactura.BuscarDetalleFactura(VentaClientes, DetalleFacturas);
                                    break;
                                default:
                                    break;
                            }
                            Console.WriteLine("\n-----Módulo Ventas-----\n¿Qué desea elegir?: \n1. Realizar venta \n2. Buscar factura \nVolver(Cualquier otro número)");
                            try
                            {
                                respuesta = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\nDigite valores numéricos\nMódulo Ventas-----\n¿Qué desea elegir?: \n1. Realizar venta \n2. Buscar factura \nVolver(Cualquier otro número)");
                                respuesta = int.Parse(Console.ReadLine());
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n-----Módulo Reportes-----\n¿Qué desea elegir?: \n1. Listar clientes \n2. Listar productos \n3. Listar facturas \nVolver(Cualquier otro número)");
                        try
                        {
                            respuesta = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\nDigite valores numéricos\n-----Módulo Reportes-----\n¿Qué desea elegir?: \n1. Listar clientes \n2. Listar productos \n3. Listar facturas \nVolver(Cualquier otro número)");
                            respuesta = int.Parse(Console.ReadLine());
                        }
                        while (respuesta >= 1 && respuesta <= 3)
                        {
                            switch (respuesta)
                            {
                                case 1:
                                    Console.WriteLine("------Clientes------");
                                    _clienteServicio.ListarClientes(ListaClientes);
                                    break;
                                case 2:
                                    Console.WriteLine("------Productos------");
                                    _productoServicio.ListarProductos(ListaProductos);
                                    break;
                                case 3:
                                    Console.WriteLine("------Facturas------");
                                    _listarFacturas.Listar(Encabezados);
                                    break;
                                default:
                                    break;
                            }
                            Console.WriteLine("\n-----Módulo Reportes-----\n¿Qué desea elegir?: \n1. Listar clientes \n2. Listar productos \n3. Listar facturas \nVolver(Cualquier otro número)");
                            try
                            {
                                respuesta = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("\nDigite valores numéricos\n-----Módulo Reportes-----\n¿Qué desea elegir?: \n1. Listar clientes \n2. Listar productos \n3. Listar facturas \nVolver(Cualquier otro número)");
                                respuesta = int.Parse(Console.ReadLine());
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("\n-----Módulo Configuración-----\n¿Qué desea hacer?\n1.Llenar información\n2.Cambiar nombre de la empresa?\nVolver(otro número)");
                        try
                        {
                            respuesta = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\nDigite valores numéricos\n-----Módulo Configuración-----\n¿Qué desea hacer?\n1.Llenar información\n2.Cambiar nombre de la empresa?\nVolver(otro número)");
                            respuesta = int.Parse(Console.ReadLine());
                        }
                        switch (respuesta)
                        {
                            case 1:
                                Configuracion.ConfiguracionEmpresa(ListaProductos, ListaClientes);
                                break;
                            case 2:
                                NombreEmpresa = Configuracion.NombreEmpresa();
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"\n-----Menu Principal {NombreEmpresa}-----\n¿Qué opción desea elegir?: \nModulo1: Clientes\nModulo2: Productos\nModulo3: Ventas\nModulo4: Reportes\nModulo5: Configuración ");
                try
                {
                    respuesta = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine($"\n¡DIGITE UN NÚMERO!\n-----Menu Principal {NombreEmpresa}-----\n¿Qué opción desea elegir?: \nModulo1: Clientes\nModulo2: Productos\nModulo3: Ventas\nModulo4: Reportes\nModulo5: Configuración ");
                    respuesta = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}