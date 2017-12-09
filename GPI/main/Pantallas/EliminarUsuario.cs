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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Listas.lista_usuario lu = new Listas.lista_usuario();
            lu.ShowDialog();
            if (lu.DialogResult == DialogResult.OK)
            {
                txtIDusuario.Text = lu.id;
                txtNombre.Text = lu.nom;
                
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
