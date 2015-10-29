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
    public partial class FormListar : Form
    {
        ProductoAPI productoapi;
        public FormListar(ProductoAPI mani)
        {
            InitializeComponent();
            productoapi = mani;
            
        }
        
        private void FormListar_Load(object sender, EventArgs e)
        {
            cargaLista();
            
        }
        public void cargaLista()
        {
            List<Producto> listaImportada = productoapi.mostrarTodo();
            lista.Items.Clear();

            switch (productoapi.numeroProductos())
            {
                case 0:
                    txtStatus.Text = " No Hay Productos que mostrar";
                    break;
                case 1:
                    txtStatus.Text = "Hay 1 producto";
                    break;
                default:
                    txtStatus.Text = "Hay " + productoapi.numeroProductos() + " producto(s)";
                    break;
            }
            foreach (var producto in listaImportada)
            {
                lista.Items.Add(String.Format("{0}", producto.nombre));
            }

        }
        private void lista_DoubleClick(object sender, EventArgs e)
        {

        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String nombreUsado = lista.GetItemText(lista.SelectedItem);
            Producto producto = productoapi.buscaObjeto(nombreUsado);
            if (producto != null)
            {
                txtCantidad.Text = producto.cantidad.ToString();
                txtPrecio.Text = producto.precio.ToString();
            }
            else
            {
                txtStatus.Text = "Error buscando " + nombreUsado;
            }
            
        }

        private void btnRecarga_Click(object sender, EventArgs e)
        {
            cargaLista();
        }
    }
}
