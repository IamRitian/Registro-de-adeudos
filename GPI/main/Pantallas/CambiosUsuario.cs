using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main.Pantallas
{
    public partial class CambiosUsuario : Form
    {
        public CambiosUsuario()
        {
            InitializeComponent();
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            PantallasExtra.listaEC le = new PantallasExtra.listaEC();
            le.ShowDialog();
            if (le.DialogResult == DialogResult.OK)
            {
                txtIDusuario.Text = le.id;
                txtNombre.Text = le.nom;
                txtIDdepartamento.Text = le.idDept;
                txtCodigo.Text = le.cod;
            }
        }

        BasedeDatos con = new BasedeDatos();
        SqlCommand cmd;
        SqlDataReader dr;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Hide();
        }
        public void limpiar()
        {
            txtCodigo.Text = "";
            txtIDdepartamento.Text = "";
            txtIDusuario.Text = "";
            txtNombre.Text = "";
        }

        private void txtIDempleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && !string.IsNullOrEmpty(txtIDusuario.Text))
                {
                    e.Handled = true;

                    con.abrirbd();
                    SqlCommand cmd = new SqlCommand("select Nombre, No_departamento, Codigo from Usuarios where IDusuario=" + txtIDusuario.Text + "", con.conecta);
                    SqlDataReader dr1 = cmd.ExecuteReader();
                    if (dr1.Read())
                    {
                        txtNombre.Text = dr1[0].ToString();
                        txtIDdepartamento.Text = dr1[1].ToString();
                        txtCodigo.Text = dr1[2].ToString();
                        con.cerrarbd();
                        txtNombre.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Tecle ID del empleado para continuar.");
                }
            }
        }

        //private void btnID_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void btnDepart_Click(object sender, EventArgs e)
        //{
        //    txtIDdepartamento.Text = "";
        //    PantallasExtra.listaED ld = new PantallasExtra.listaED();
        //    ld.ShowDialog();
        //    if (ld.DialogResult == DialogResult.OK)
        //    {
        //        txtIDdepartamento.Text = ld.id;
        //    }
        //}

        //private void btnCambiar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(txtIDempleado.Text)
        //            || !!string.IsNullOrEmpty(txtCodigo.Text)
        //            || !string.IsNullOrEmpty(txtIDdepartamento.Text)
        //            || !string.IsNullOrEmpty(txtNombre.Text))
        //        {
        //            metodos m = new metodos();
        //            int id = int.Parse(txtIDempleado.Text);
        //            string n = txtNombre.Text;
        //            int de = int.Parse(txtIDdepartamento.Text);
        //            int c = int.Parse(txtCodigo.Text);
        //            m.actualizarEmpleado(id, n, de, c);
        //            limpiar();
        //            MessageBox.Show("Datos del empleado actualizado.");
        //            this.Hide();
        //        }
        //        else { MessageBox.Show("Uno o dos campos del formulario estan vacios."); }

        //    }
        //    catch (Exception ex) { MessageBox.Show("Error al actualizar datos. " + ex.ToString()); }


        //}
    }
}
