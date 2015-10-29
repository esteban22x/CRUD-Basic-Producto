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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        AgregaPro agrega = null;
        ModificaPro modifica = null;
        FormListar listar = null;
        ProductoAPI manipulacion = new ProductoAPI();
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if (agrega == null)
            {
                agrega = new AgregaPro(manipulacion);
                agrega.MdiParent = this;
                
            }
            agrega.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            agrega.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if (modifica == null)
            {
                modifica = new ModificaPro(manipulacion);
                modifica.MdiParent = this;

            }
            modifica.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            modifica.Show();
        }

        private void listaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            if (listar == null)
            {
                listar = new FormListar(manipulacion);
                listar.MdiParent = this;

            }
            listar.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            listar.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mini Programa creado por Esteban Delgado para IUCMC");
        }
    }
}
