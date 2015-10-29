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
    public partial class ModificaPro : Form
    {
        bool bandera = false;
        ProductoAPI productoapi;
        string nombreViejo = "";
        int cantidad;
        int precio;
        public ModificaPro(ProductoAPI manipulacion)
        {
            InitializeComponent();
            productoapi = manipulacion;
        }
        private void hayElementos()
        {
            if (productoapi.numeroProductos() == 0)
            {
                txtStatus.Text = "No Hay Elementos :(";
                btnBuscar.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                
            }else{
                txtStatus.Text = "";
                
                btnBuscar.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }
        private void ModificaPro_Load(object sender, EventArgs e)
        {
            hayElementos();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bandera && nombreViejo!="")
            {
                if (txtModNombre.Text.Trim() != "" && Int32.TryParse(txtModPrecio.Text,out precio) && Int32.TryParse(txtModCantidad.Text, out cantidad))
                {
                    Producto pr = new Producto(txtModNombre.Text, precio, cantidad);
                    if (productoapi.modificarProducto(nombreViejo, pr)){
                        txtStatus.Text = "Producto correctamente Modificado";
                        bandera = false;
                        limpiarTodo();
                    }else {
                        txtStatus.Text = "Error: El nombre original no es válido";
                    }
                    
                }
                else { txtStatus.Text = "Datos Invalidos/Incompletos"; }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombreBusca.Text.Trim() != "")
            {
                nombreViejo = txtNombreBusca.Text;
                Producto pro = productoapi.buscaObjeto(nombreViejo);
                if (pro != null)
                {
                    txtModNombre.Text = pro.nombre;
                    txtModCantidad.Text = pro.cantidad.ToString();
                    txtModPrecio.Text = pro.precio.ToString();
                    txtStatus.Text = "Se encontró algo. Haz tus cambios";
                    bandera = true;
                }
                else{
                    txtStatus.Text = "No se encuentra nada";
                    bandera = false;
                }
            }
            else {
                txtStatus.Text = "Ingresa un nombre válido para buscar";
                bandera = false; }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (bandera && nombreViejo != "")
            {
                if (productoapi.eliminarProducto(nombreViejo) && (MessageBox.Show("¿Realmente desea Eliminar el elemento llamado "+nombreViejo+"?", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
                {
                    txtStatus.Text = "Producto correctamente Eliminado";
                    bandera = false;
                    limpiarTodo();
                }
                else
                {
                    txtStatus.Text = "";
                }
            }
        }
        private void limpiarTodo()
        {
            txtModCantidad.Text = "";
            txtModNombre.Text = "";
            txtModPrecio.Text = "";
            txtNombreBusca.Text = "";
        }

        private void reintentar_Click(object sender, EventArgs e)
        {
            hayElementos();
        }
    }
}
