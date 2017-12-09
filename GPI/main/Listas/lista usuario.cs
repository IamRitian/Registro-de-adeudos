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
    public partial class lista_usuario : Form
    {
        public lista_usuario()
        {
            InitializeComponent();
        }
        BasedeDatos bd = new BasedeDatos();
        public string id;
        public string nom;
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //bd.cargarA(dataGridView1, cbOpcion, txtTexto);
              //txtTexto.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error formato.");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nom = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
            txtTexto.Text = "";
            DialogResult = DialogResult.OK;

            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
    }
}
