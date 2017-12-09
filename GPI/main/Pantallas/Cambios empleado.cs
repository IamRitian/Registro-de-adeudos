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
    public partial class Cambios_empleado : Form
    {
        public Cambios_empleado()
        {
            InitializeComponent();
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
            txtIDempleado.Text = "";
            txtNombre.Text = "";
        }

        private void txtIDempleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && !string.IsNullOrEmpty(txtIDempleado.Text))
                {
                    e.Handled = true;

                    con.abrirbd();
                    SqlCommand cmd = new SqlCommand("select Nombre, No_departamento, Codigo from Empleados where No_empleado=" + txtIDempleado.Text + "", con.conecta);
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

        private void btnID_Click(object sender, EventArgs e)
        {
            PantallasExtra.listaEC le = new PantallasExtra.listaEC();            
            le.ShowDialog();
            if (le.DialogResult == DialogResult.OK)
            {
                txtIDempleado.Text = le.id;
                txtNombre.Text = le.nom;
                txtIDdepartamento.Text = le.idDept;
                txtCodigo.Text = le.cod;
            }
        }

        private void btnDepart_Click(object sender, EventArgs e)
        {
            txtIDdepartamento.Text = "";
            PantallasExtra.listaED ld = new PantallasExtra.listaED();            
            ld.ShowDialog();
            if (ld.DialogResult==DialogResult.OK)
            {
                txtIDdepartamento.Text = ld.id;
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIDempleado.Text)
                    ||!!string.IsNullOrEmpty(txtCodigo.Text)
                    || !string.IsNullOrEmpty(txtIDdepartamento.Text)
                    || !string.IsNullOrEmpty(txtNombre.Text))
                {
                    metodos m = new metodos();
                    int id = int.Parse(txtIDempleado.Text);
                    string n = txtNombre.Text;
                    int de = int.Parse(txtIDdepartamento.Text);
                    int c = int.Parse(txtCodigo.Text);
                    m.actualizarEmpleado(id, n, de, c);
                    limpiar();
                    MessageBox.Show("Datos del empleado actualizado.");
                    this.Hide();
                }else { MessageBox.Show("Uno o dos campos del formulario estan vacios."); }
                
            }catch (Exception ex) { MessageBox.Show("Error al actualizar datos. "+ex.ToString()); }
            
            
        }

        private void Cambios_empleado_Load(object sender, EventArgs e)
        {
            //Listas.lista_empleado le = new Listas.lista_empleado();
            
        }

        public void autoCompletarTxtbox(TextBox txt)
        {
            try
            {
                cmd = new SqlCommand("select * from Empleados", con.conecta);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ex.ToString());
                throw;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtIDdepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
