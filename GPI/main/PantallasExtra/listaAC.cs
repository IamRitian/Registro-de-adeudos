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
    public partial class listaAC : Form
    {
        public listaAC()
        {
            InitializeComponent();
        }
        BasedeDatos bd = new BasedeDatos();
        public string idArticulo;
        public string desc;
        public string precio;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idArticulo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            desc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTexto.Text = "";
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listaAC_Load(object sender, EventArgs e)
        {
            bd.cargarArticulos(dataGridView1);
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
                bd.cargarA(dataGridView1, cbOpcion, txtTexto);
                txtTexto.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Error de formato.");
            }
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bd.cargarArticulos(dataGridView1);
        }
    }
}
