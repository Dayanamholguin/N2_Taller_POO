using System;
using System.Collections.Generic;
using System.Linq;
namespace N2_Taller_POO.Servicios
{
    class ProductoServicio
    {
        public String Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public int Codigo { get; set; }
        public int rresultado = 0;
       
        public void Crear(List<Producto> ListaProductos)
        {
            String respuesta;
            do
            {
                Console.Write("--------------------\nCREAR PRODUCTO\nDigite código del producto: ");
                try
                {
                    Codigo = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite valores numéricos\nDigite código del producto: ");
                    Codigo = int.Parse(Console.ReadLine());
                }
                while (ValidarProducto(Codigo, ListaProductos))
                {
                    Console.Write("\nEse código de producto ya existe,\ndigite otro código del producto: ");
                    Codigo = int.Parse(Console.ReadLine());
                }
                Console.Write("Digite nombre del producto: ");
                Nombre = Console.ReadLine();
                Console.Write("Digite precio del producto: ");
                try
                {
                    Precio = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Digite valores numéricos\nDigite precio del producto: ");
                    Precio = double.Parse(Console.ReadLine());
                }
                Console.Write("Digite cantidad del producto: ");
                try
                {
                    Cantidad = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Digite valores numéricos\nDigite cantidad del producto: ");
                    Cantidad = int.Parse(Console.ReadLine());
                }
                Producto producto = new Producto(Nombre, Precio, Cantidad, Codigo);
                ListaProductos.Add(producto);
                Console.WriteLine("\nSe agregó correctamente\n________________________");

                Console.Write("¿Desea registrar a otro producto? SI/NO: ");
                respuesta = Console.ReadLine();

            } while (respuesta.Equals("SI"));
        }

        public void Buscar(List<Producto> ListaProductos)
        {
            Console.Write("--------------------\nBUSCAR PRODUCTO\nDigite código de producto: ");
            try
            {
                Codigo = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite valores numéricos\nDigite código de producto: ");
                Codigo = int.Parse(Console.ReadLine());
            }
            var consulta = ListaProductos.Where(codigo => codigo.Codigo == Codigo).ToList();
            if (consulta.Count > 0)
            {
                foreach (var producto in consulta)
                {
                    Console.WriteLine("\nCódigo: " + producto.Codigo + "\nNombre: " + producto.Nombre + "\nPrecio: " + producto.Precio + "\nCantidad: " + producto.Cantidad);
                }
            }
            else Console.WriteLine("No se encontró\n________________________");
        }

        private bool ValidarProducto(int codigo, List<Producto> ListaProductos)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Codigo == codigo) return true;
            }
            return false;
        }

        public void Editar(List<Producto> ListaProductos)
        {
            Console.Write("--------------------\nEDITAR PRODUCTO\nIngrese el código del producto que desea editar: ");
            try
            {
                Codigo = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite valores numéricos\nIIngrese el código del producto que desea editar: ");
                Codigo = int.Parse(Console.ReadLine());
            }

            var consulta = ListaProductos.FindIndex(c => c.Codigo == Codigo);

            if (consulta != -1)
            {
                var consulta1 = ListaProductos.Where(c => c.Codigo == Codigo).FirstOrDefault();
                int restante = consulta1.Cantidad;
                Console.Write("--------------------\nIngrese los nuevos datos\n");
                Console.Write("Digite nuevo nombre del producto: ");
                Nombre = Console.ReadLine();
                Console.Write("Digite nuevo precio del producto: ");
                try
                {
                    Precio = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Digite valores numéricos\nDigite nuevo precio del producto: ");
                    Precio = double.Parse(Console.ReadLine());
                }
                Console.Write("Digite nueva cantidad del producto: ");
                try
                {
                    Cantidad = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Digite valores numéricos\nDigite nueva cantidad del producto: ");
                    Cantidad = int.Parse(Console.ReadLine());
                }
                consulta1.Nombre = Nombre;
                consulta1.Precio = Precio;
                int _resultado = Cantidad + restante;
                consulta1.Cantidad = _resultado;
                Console.WriteLine("\nSe actualizó correctamente\n________________________");
            }
            else Console.WriteLine("\nNo se encontró el producto\n________________________");

        }

        public void Eliminar(List<Producto> ListaProductos)
        {
            Console.Write("--------------------\nELIMINAR CLIENTE\nIngrese el código del producto que desea eliminar: ");
            try
            {
                Codigo = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite valores numéricos\nIngrese el código del producto que desea eliminar: ");
                Codigo = int.Parse(Console.ReadLine());
            }
            var consulta = ListaProductos.Any(c => c.Codigo == Codigo);
            if (consulta)
            {
                ListaProductos.RemoveAt(ListaProductos.IndexOf(ListaProductos.Single(_productos => _productos.Codigo == Codigo)));
                Console.WriteLine("\nSe eliminó correctamente\n________________________");
            }
            else Console.WriteLine("\nNo se encontró el producto\n________________________");

        }

        public void ListarProductos(List<Producto> ListaProductos)
        {
            String Mensaje="";
            if (ListaProductos.Count == 0)
            {
                Console.WriteLine("No hay productos");
            }
            else
            {
                foreach (var _listaProductos in ListaProductos)
                {
                    Mensaje = _listaProductos.Cantidad == 0 ? "NO HAY, LLENAR POR FAVOR." : "";
                    
                    Console.WriteLine($"Nombre: {_listaProductos.Nombre}   Precio: {_listaProductos.Precio}   Cantidad: {_listaProductos.Cantidad}   Código: {_listaProductos.Codigo}  {Mensaje}");
                }
            }
        }
    }
}
