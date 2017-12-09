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
    public partial class lista_articulos : Form
    {
        public lista_articulos()
        {
            InitializeComponent();
        }
        BasedeDatos BD = new BasedeDatos();
        public string clv;
        public string desp;
        public string p;
        private void lista_articulos_Load(object sender, EventArgs e)
        {
            
            BD.cargarArticulos(dataGridView1);
            cbOpcion.SelectedIndex = 0;
            txtTexto.Focus();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clv = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            desp = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            p = dataGridView1.CurrentRow.Cells[2].Value.ToString();
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
                BD.cargarA(dataGridView1, cbOpcion, txtTexto);
                txtTexto.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error formato.");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            BD.cargarArticulos(dataGridView1);
        }

        private void cbOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
