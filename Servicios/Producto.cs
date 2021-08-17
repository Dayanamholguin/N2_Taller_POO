using System;
namespace N2_Taller_POO.Servicios
{
    class Producto
    {
        public String Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public int Codigo { get; set; }

        public Producto()
        {

        }
        public Producto(String Nombre, double Precio, int Cantidad, int Codigo)
        {
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
            this.Codigo = Codigo;
        }

    }
}