using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAL
{
    public class ProductoAPI
    {
        public List<Producto> prod = new List<Producto>();
        
        public Producto buscaObjeto(String nombre)
        {
            Producto resultado = null;
            if (prod != null){
                foreach (var elemento in prod){
                    if (elemento.nombre.ToLower() == nombre.ToLower()){
                        resultado = elemento;
                    }
                }
            }
            
            return resultado;
        }
        public int numeroProductos()
        {
            return prod.Count;
        }
        public bool modificarProducto(String nombre,Producto producto)
        {
            bool res = false;
            Producto obj = buscaObjeto(nombre);
            if (obj != null)
            {
                obj.nombre = producto.nombre;
                obj.precio = producto.precio;
                obj.cantidad = producto.cantidad;
                res = true;
            }
            return res;
        }
        public bool agregarProducto(Producto producto)
        {
            bool fi = false;
            if (producto.nombre.Trim() != "" && buscaObjeto(producto.nombre) == null)
            {
                prod.Add(producto);
                fi = true;
            }
            return fi;       
        }
        public bool eliminarProducto(String nombre)
        {
            bool fi = false;
            if (nombre.Trim() != "" && buscaObjeto(nombre) != null)
            {
                prod.Remove(buscaObjeto(nombre));
                fi = true;
            }
            return fi;
        }
        public String mostrarProducto(String nombre)
        {
            Producto producto = buscaObjeto(nombre);
            if (producto.nombre.Trim() != "" && producto != null)
            {
                return "Nombre " + producto.nombre + " , Precio: $" + producto.precio + " , Cantidad: " + producto.cantidad;
            }
            return "No se encuentra";
        }
        public List<Producto> mostrarTodo()
        {
            return prod;
        }
    }
}
