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
    public partial class Registrar_empleado : Form
    {
        public Registrar_empleado()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        BasedeDatos con = new BasedeDatos();
        SqlCommand cmd = new SqlCommand();
        metodos m = new metodos();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text)||
                !string.IsNullOrEmpty(txtNombre.Text) ||
                !string.IsNullOrEmpty(txtDepartamento.Text) ||
                !string.IsNullOrEmpty(txtCodigo.Text)
                )
            {try
                {
                con.abrirbd();
                SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Empleados where Nombre like '%"+txtNombre.Text+"%'", con.conecta);
                DataTable tabla = new DataTable();
                a.Fill(tabla);
                con.cerrarbd();
                
                    if (tabla.Rows.Count==0)
                    {
                        m.agregaEmpleado(int.Parse(txtID.Text), txtNombre.Text, int.Parse(txtDepartamento.Text), txtCodigo.Text);
                        m.agregaEL(int.Parse(txtID.Text), int.Parse(txtDepartamento.Text));
                        limpiar();
                        DialogResult dialogResult = MessageBox.Show("Se agregó empleado correctamente. ¿Desea agregar otro empleado?", "Capturar empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (dialogResult == DialogResult.Yes)
                        {
                            txtID.Focus();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            this.Hide();
                        }
                    }
                    else if (tabla.Rows[0][1].ToString() == txtNombre.Text)
                    {
                        limpiar();
                        txtID.Focus();
                        MessageBox.Show("Este empleado ya esta registrado.", "Registro de empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar empleado. " + ex.ToString(), "Error");
                }
            }
            else
            {
                MessageBox.Show("Uno o varios campos estan vacios debe llenarlos para continuar.");
            }
        }

        public void limpiar()
        {
            txtCodigo.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            txtDepartamento.Text = "";
            //cboDept.SelectedIndex = 0;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber((char)(e.KeyChar)) &&
            (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse("."))&&
            e.KeyChar != (char)(Keys.Back)&&
            e.KeyChar !=(char)(Keys.OemPeriod))
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    txtNombre.Focus();
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && 
                e.KeyChar != '\b' && 
                e.KeyChar !=((char)(Keys.Space))&&
                (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")))
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    txtDepartamento.Focus();
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit((char)(e.KeyChar)) &&
            e.KeyChar == Convert.ToChar(Keys.Enter) &&
            (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")) &&
            e.KeyChar != (char)(Keys.Back) &&
            e.KeyChar != (char)(Keys.OemPeriod))
            {
                e.Handled = true;
                btnAceptar.Focus();
            }
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            txtDepartamento.Text = "";
            Listas.lista_departamentos ld = new Listas.lista_departamentos();
            ld.ShowDialog();
            if (ld.DialogResult==DialogResult.OK)
            {
                txtDepartamento.Text = ld.id;
            }
            txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber((char)(e.KeyChar)) &&
            (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")) &&
            e.KeyChar != (char)(Keys.Back) &&
            e.KeyChar != (char)(Keys.OemPeriod))
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    txtCodigo.Focus();
                }
            }
        }
    }
}
