using System;
using System.Collections.Generic;
namespace N2_Taller_POO.Servicios
{
    class Configuracion
    {
        public static String NombreEmpresa()
        {
            Console.WriteLine("Digite nuevo nombre de la empresa: ");
            String NombreEmpresa = Console.ReadLine();
            return NombreEmpresa;
        }
        public static void ConfiguracionEmpresa(List<Producto> ListaProductos, List<Cliente> ListaClientes)
        {
            var Random = new Random().Next(1000000000, 2000000000);
            Cliente _cliente1 = new Cliente("Dayana", "Cra 78", 1234, Random);
            ListaClientes.Add(_cliente1);
            Cliente _cliente2 = new Cliente("Juan", "Cra 56", 234, 123);
            ListaClientes.Add(_cliente2);
            Cliente _cliente3 = new Cliente("Marlon", "Cra 98", 688, 124);
            ListaClientes.Add(_cliente3);
            Cliente _cliente4 = new Cliente("Laura", "Cra 78", 1234, Random);
            ListaClientes.Add(_cliente4);
            Cliente _cliente5 = new Cliente("Carlos", "Cra 56", 234, Random);
            ListaClientes.Add(_cliente5);
            Cliente _cliente6 = new Cliente("Sofia", "Cra 98", 688, Random);
            ListaClientes.Add(_cliente6);
            Cliente _cliente7 = new Cliente("Lauro", "Cra 98", 688, Random);
            ListaClientes.Add(_cliente7);
            Cliente _cliente8 = new Cliente("Melissa", "Cra 56", 234, Random);
            ListaClientes.Add(_cliente8);
            Cliente _cliente9 = new Cliente("Jose", "Cra 98", 688, Random);
            ListaClientes.Add(_cliente9);
            Cliente _cliente10 = new Cliente("Mariana", "Cra 98", 688, Random);
            ListaClientes.Add(_cliente10);

            Producto _producto1 = new Producto("Leche", 2000,10,22);
            ListaProductos.Add(_producto1);
            Producto _producto2 = new Producto("Arepas", 1100, 12, 23);
            ListaProductos.Add(_producto2);
            Producto _producto3 = new Producto("Jabón de baño", 1000, 14, 24);
            ListaProductos.Add(_producto3);
            Producto _producto4 = new Producto("Yogurt", 1500, 10, 25);
            ListaProductos.Add(_producto4);
            Producto _producto5 = new Producto("Papitas de limón", 1200, 12, 26);
            ListaProductos.Add(_producto5);
            Producto _producto6 = new Producto("Bocadillo", 1000, 14, 27);
            ListaProductos.Add(_producto6);
            Producto _producto7 = new Producto("Nutella", 10000, 10, 28);
            ListaProductos.Add(_producto7);
            Producto _producto8 = new Producto("Arroz", 1400, 12, 29);
            ListaProductos.Add(_producto8);
            Producto _producto9 = new Producto("Aceite", 2300, 14, 29);
            ListaProductos.Add(_producto9);
            Producto _producto10 = new Producto("Frijoles", 3500, 10, 30);
            ListaProductos.Add(_producto10);
            Console.WriteLine("\nFue llenado exitosamente\n____________________");

        }
    }
}