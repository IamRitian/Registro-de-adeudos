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
    public partial class lista_departamentos : Form
    {
        public lista_departamentos()
        {
            InitializeComponent();
        }
        BasedeDatos bd = new BasedeDatos();
        public string id;
        private void lista_departamentos_Load(object sender, EventArgs e)
        {
            
            bd.cargarDepartamento(dataGridView1);
            txtTexto.Focus();
            cbOpcion.SelectedIndex = 0;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult = DialogResult.OK;
            txtTexto.Text = "";
            this.Close();
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                bd.cargarD(dataGridView1, cbOpcion, txtTexto);
                txtTexto.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Error de formato.");
            }
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bd.cargarDepartamento(dataGridView1);
        }
    }
}
