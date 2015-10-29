using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForAL
{
    public partial class AgregaPro : Form
    {
        ProductoAPI productoapi;
        public AgregaPro(ProductoAPI manipulacion)
        {
            InitializeComponent();
            productoapi = manipulacion;
        }

        private void AgregaPro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgrego_Click(object sender, EventArgs e)
        {
            String nombre = txtAgNombre.Text;
            int cantidad;
            int precio;
            
            if (Int32.TryParse(txtAgCantidad.Text,out cantidad) && Int32.TryParse(txtAgPrecio.Text, out precio))
            {
                Producto pr = new Producto(nombre, precio, cantidad);
                if (productoapi.agregarProducto(pr)){
                    txtStatus.Text = "Agregado Correctamente";
                    txtAgNombre.Text = "";
                    txtAgCantidad.Text = "";
                    txtAgPrecio.Text = "";
                    txtStatus.Visible = true;
                }
                else{
                    txtStatus.Text = "Error: Parametro Nombre Invalido (Asegurate de que lo escribiste bien y que es un nuevo valor)";
                    txtStatus.Visible = true;
                }
            }
            else{
                txtStatus.Text = "Precio/Cantidad deben ser numeros";
                txtStatus.Visible = true;
            }
        }
    }
}
