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
    public partial class Eliminar_Empleado : Form
    {
        public Eliminar_Empleado()
        {
            InitializeComponent();
        }


        int id;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIDempleado.Text = "";
            txtDep.Text = "";
            txtNombre.Text = "";
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            id = int.Parse(txtIDempleado.Text);
            metodos m = new metodos();
            Pantallas.Adeudo ad = new Adeudo(id);
            ad.Show();
            
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar empleado?", "Eliminar empleado", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                m.eliminarEmpleado(int.Parse(txtIDempleado.Text));
                txtIDempleado.Text = "";
                DialogResult d = MessageBox.Show("¿Desea eliminar otro empleado?", "Eliminar empleado", MessageBoxButtons.YesNo);
                if (d==DialogResult.Yes)
                {
                    txtDep.Text = "";
                    txtNombre.Text = "";
                    //ad.Close();
                }
                else if (d==DialogResult.No)
                {
                    this.Close();
                }
                
            }
            else if (dialogResult == DialogResult.No)
            {
                ad.Close();
                this.Close();
            }
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PantallasExtra.listaEE le = new PantallasExtra.listaEE();
            le.ShowDialog();
            if (le.DialogResult==DialogResult.OK)
            {
                txtIDempleado.Text = le.id;
                txtNombre.Text = le.nom;
                txtDep.Text = le.dept;
            }
        }

        private void Eliminar_Empleado_Load(object sender, EventArgs e)
        {
            
            txtIDempleado.Focus();
        }
        
    }
}
