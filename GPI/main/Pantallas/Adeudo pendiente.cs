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
    public partial class Adeudo_pendiente : Form
    {
        public Adeudo_pendiente()
        {
            InitializeComponent();
        }
        BasedeDatos bd = new BasedeDatos();
        metodos m = new metodos();
        private void Adeudo_pendiente_Load(object sender, EventArgs e)
        {
            
            bd.cargarAdeudoPend(DGVAdeudoP);
            //bd.aC(txtTexto);
            this.DGVAdeudoP.Columns[0].ReadOnly = true;
            //DGVAdeudoP.Columns[0].ReadOnly=true;
            //DGVAdeudoP.Columns[2].ReadOnly = false;
            //DGVAdeudoP.Columns[3].ReadOnly = false;
            //DGVAdeudoP.Columns[4].ReadOnly = false;
            //DGVAdeudoP.Columns[5].ReadOnly = false;
            //DGVAdeudoP.Columns[6].ReadOnly = false;
            //DGVAdeudoP.Columns[7].ReadOnly = false;

        }


        private void DGVAdeudoP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in DGVAdeudoP.Rows)
            {
                try
                {

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        RegistroAdeudo ra = new RegistroAdeudo();
                        ra.txtIDempleado.Text = DGVAdeudoP.CurrentRow.Cells[1].Value.ToString();
                        ra.txtNombre.Text = DGVAdeudoP.CurrentRow.Cells[2].Value.ToString();
                        ra.cboDepartamento.Text = DGVAdeudoP.CurrentRow.Cells[3].Value.ToString();
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(ra.DGVlistA);
                        fila.Cells[0].Value = row.Cells[4].Value;
                        fila.Cells[1].Value = row.Cells[5].Value;
                        fila.Cells[2].Value = row.Cells[7].Value;
                        fila.Cells[3].Value = row.Cells[8].Value;
                        ra.DGVlistA.Rows.Add(fila);
                                               
                        ra.Show();
                    }
                    else
                    {

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(""+ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void DGVAdeudoP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(DGVAdeudoP.CurrentRow.Cells[0].Value))
            {
                DGVAdeudoP.CurrentRow.Cells[0].Value = false;
                string a = DGVAdeudoP.CurrentRow.Cells[1].Value.ToString();
                string b = DGVAdeudoP.CurrentRow.Cells[4].Value.ToString();
                string c = DGVAdeudoP.CurrentRow.Cells[6].Value.ToString();
                string d = DGVAdeudoP.CurrentRow.Cells[7].Value.ToString();
                string f = DGVAdeudoP.CurrentRow.Cells[8].Value.ToString();
                m.actualizarAP1(a, b, c, d, f);
            }
            else
            {
                string a = DGVAdeudoP.CurrentRow.Cells[1].Value.ToString();
                string b = DGVAdeudoP.CurrentRow.Cells[4].Value.ToString();
                string c = DGVAdeudoP.CurrentRow.Cells[6].Value.ToString();
                string d = DGVAdeudoP.CurrentRow.Cells[7].Value.ToString();
                string f = DGVAdeudoP.CurrentRow.Cells[8].Value.ToString();
                m.actualizarAP(a, b, c, d, f);
                DGVAdeudoP.CurrentRow.Cells[0].Value = true;
            }
            
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                bd.cargarAdeudoP(DGVAdeudoP,cbOpcion,txtTexto);
                txtTexto.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error de formato.");
                
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bd.cargarAdeudoPend(DGVAdeudoP);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGVAdeudoP.Rows)
            {
                try
                {

                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        m.eliminarAP();
                        
                    }
                    else
                    {

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }
    }
}
