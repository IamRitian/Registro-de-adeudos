using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main.Listas
{
    public partial class lista_empleado : Form
    {
        public lista_empleado()
        {
            InitializeComponent();
            
        }
        
        BasedeDatos bd = new BasedeDatos();
        public string id;
        public string nom;
        public string dept;
        private void lista_empleado_Load(object sender, EventArgs e)
        {
            
            bd.cargarEmpleado(dataGridView1);
            txtTexto.Focus();
            cbOpcion.SelectedIndex = 0;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nom = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dept = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTexto.Text = "";
            DialogResult = DialogResult.OK;
            
            this.Close();
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                bd.cargarE(dataGridView1, cbOpcion, txtTexto);
                txtTexto.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Error de formato.");
            }
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bd.cargarEmpleado(dataGridView1);
        }
    }
}
