using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main.PantallasExtra
{
    public partial class listaEC : Form
    {
        public listaEC()
        {
            InitializeComponent();
        }
        BasedeDatos BD = new BasedeDatos();
        public string id, nom, idDept, cod;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nom = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            idDept = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cod = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTexto.Text = "";
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            BD.cargarE1(dataGridView1);
        }

        private void listaEC_Load(object sender, EventArgs e)
        {
            BD.cargarE1(dataGridView1);
            txtTexto.Focus();
            cbOpcion.SelectedIndex = 0;
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BD.cargarE12(dataGridView1, cbOpcion, txtTexto);
                txtTexto.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Error de formato.");
            }
            
        }
    }
}
