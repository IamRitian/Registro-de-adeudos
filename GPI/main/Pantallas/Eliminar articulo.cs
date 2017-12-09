using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main.Pantallas
{
    public partial class Eliminar_articulo : Form
    {
        public Eliminar_articulo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIDarticulo.Text = "";
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PantallasExtra.listaAD la = new PantallasExtra.listaAD();
            la.ShowDialog();
            if (la.DialogResult==DialogResult.OK)
            {
                txtIDarticulo.Text = la.id;
                txtDesc.Text = la.desc;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtIDarticulo.Text);
            metodos m = new metodos();
            m.eliminarArticulo(a);
            MessageBox.Show("Articulo eliminado.");
            txtIDarticulo.Text = "";
            txtDesc.Text = "";

            this.Close();
        }
    }
}
