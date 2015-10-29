using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAL
{
    public class Producto
    {
       

        public Producto(String nombre,int precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public String nombre { set; get; }
        public int precio { set; get; }
        public int cantidad { set; get; }

        public override string ToString()
        {
            return "Nombre: "+nombre+" Precio: $"+precio+" Cantidad: "+cantidad;
        }


    }
}
