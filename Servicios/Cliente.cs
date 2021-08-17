using System;

namespace N2_Taller_POO.Servicios
{
    class Cliente
    {
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }
        public int Cedula { get; set; }

        public Cliente()
        {

        }
        public Cliente(String Nombre, String Direccion, int Telefono, int Cedula)
        {
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Cedula = Cedula;
        }

    }
}
