using System;
using System.Collections.Generic;
using System.Linq;

namespace N2_Taller_POO.Servicios
{
    class ClienteServicio
    {
        public void Crear(List<Cliente> ListaClientes)
        {
            int Telefono, Cedula;
            String respuesta1;
            do
            {
                Console.Write("--------------------\nCREAR CLIENTE\n");
                Console.Write("Digite su cédula: ");
                try
                {
                    Cedula = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Por favor, digite valores numéricos\nDigite su cédula: ");
                    Cedula = int.Parse(Console.ReadLine());
                }
                while (ValidarCliente(Cedula, ListaClientes))
                {
                    Console.WriteLine("Ya ha sido registrado esa cédula\nDigite otro número de cédula");
                    Cedula = int.Parse(Console.ReadLine());
                }
                Console.Write("Digite su nombre:");
                string Nombre = Console.ReadLine();
                Console.Write("Digite su direccion:");
                string Direccion = Console.ReadLine();
                Console.Write("Digite su teléfono:");
                try
                {
                    Telefono = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Por favor, digite valores numéricos\nDigite su teléfono:");
                    Telefono = int.Parse(Console.ReadLine());
                }

                Cliente _cliente = new Cliente(Nombre, Direccion, Telefono, Cedula);
                ListaClientes.Add(_cliente);
                Console.WriteLine("\nSe agregó correctamente\n________________________");

                Console.Write("¿Desea registrar a otro cliente? SI/NO: ");
                respuesta1 = Console.ReadLine();

            } while (respuesta1.Equals("SI"));

        }

        private bool ValidarCliente(int cedula, List<Cliente> ListaClientes)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Cedula == cedula) return true;
            }
            return false;
        }

        public void Buscar(List<Cliente> ListaClientes)
        {
            int cedula;
            Console.Write("--------------------\nBUSCAR CLIENTE\nIngrese la cédula del cliente que desea buscar: ");
            try
            {
                cedula = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite valores numéricos\nIngrese la cédula del cliente que desea buscar: ");
                cedula = int.Parse(Console.ReadLine());
            }
            var consulta = ListaClientes.Where(_cliente => _cliente.Cedula == cedula).ToList();

            if (consulta.Count > 0)
            {
                foreach (var Cliente in consulta)
                {
                    Console.WriteLine("\nDatos del cliente que buscó\nNombre: " + Cliente.Nombre + "\nDirección:" + Cliente.Direccion + "\nTeléfono:" + Cliente.Telefono + "\nCédula:" + Cliente.Cedula);
                }
            }
            else
                Console.WriteLine("No se encontró\n________________________");
        }
        public void Editar(List<Cliente> ListaClientes)
        {
            int cedula;
            Console.Write("--------------------\nEDITAR CLIENTE\nIngrese la cédula del cliente que desea editar: ");
            try
            {
                cedula = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite valores numéricos\nIngrese la cédula del cliente que desea editar: ");
                cedula = int.Parse(Console.ReadLine());
            }

            var consulta = ListaClientes.FindIndex(c => c.Cedula == cedula);

            if (consulta != -1)
            {
                int Telefono;
                var consulta1 = ListaClientes.Where(c => c.Cedula == cedula).FirstOrDefault();
                Console.Write("--------------------\nIngrese los nuevos datos\n");
                Console.Write("Digite nuevo nombre: ");
                String Nombre = Console.ReadLine();
                Console.Write("Digite nueva dirección: ");
                String Direccion = Console.ReadLine();
                Console.Write("Digite nuevo teléfono: ");
                try
                {
                    Telefono = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Por favor, digite valores numéricos\nDigite nuevo teléfono: ");
                    Telefono = int.Parse(Console.ReadLine());
                }
                consulta1.Nombre = Nombre;
                consulta1.Direccion = Direccion;
                consulta1.Telefono = Telefono;
                Console.WriteLine("\nSe actualizó correctamente\n________________________");
            }
            else Console.WriteLine("No se encontró\n________________________");

        }
        public void Eliminar(List<Cliente> ListaClientes)
        {
            int Cedula;
            Console.Write("--------------------\nELIMINAR CLIENTE\nIngrese la cédula del cliente que desea eliminar: ");
            try
            {
                Cedula = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("Por favor, digite valores numéricos\nIngrese la cédula del cliente que desea eliminar: ");
                Cedula = int.Parse(Console.ReadLine());
            }
            var consulta = ListaClientes.Any(c => c.Cedula == Cedula);
            if (consulta)
            {
                ListaClientes.RemoveAt(ListaClientes.IndexOf(ListaClientes.Single(i => i.Cedula == Cedula)));
                Console.WriteLine("\nSe eliminó correctamente\n________________________");
            }
            else Console.WriteLine("No se encontró\n________________________");
        }
        public void ListarClientes(List<Cliente> ListaClientes)
        {
            if (ListaClientes.Count <= 0)
            {
                Console.WriteLine("No Hay Clientes");
            }
            else
            {
                foreach (var _listaClientes in ListaClientes)
                {
                    Console.WriteLine($"Nombre: {_listaClientes.Nombre}   Dirección: {_listaClientes.Direccion}   Teléfono: {_listaClientes.Telefono}   Cédula: {_listaClientes.Cedula}");
                }
            }
        }
    }
}