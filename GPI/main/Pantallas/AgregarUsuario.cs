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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }
        BasedeDatos con = new BasedeDatos();
        SqlCommand cmd = new SqlCommand();
        metodos m = new metodos();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text) ||
                !string.IsNullOrEmpty(txtNombre.Text) ||
                !string.IsNullOrEmpty(txtClave.Text) ||
                !string.IsNullOrEmpty(cbPrivilegio.Text)
                )
            {
                try
                {
                    con.abrirbd();
                    SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Usuario where Nombre like '%" + txtNombre.Text + "%'", con.conecta);
                    DataTable tabla = new DataTable();
                    a.Fill(tabla);
                    con.cerrarbd();

                    if (tabla.Rows.Count == 0)
                    {
                        m.agregarUsuario(int.Parse(txtID.Text), txtNombre.Text, txtClave.Text, cbPrivilegio.Text);
                       
                        limpiar();
                        DialogResult dialogResult = MessageBox.Show("Se agregó usuario correctamente. ¿Desea agregar otro usuario?", "Capturar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (dialogResult == DialogResult.Yes)
                        {
                            txtID.Focus();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            this.Close();
                        }
                    }
                    else if (tabla.Rows[0][1].ToString() == txtNombre.Text)
                    {
                        limpiar();
                        txtID.Focus();
                        MessageBox.Show("Este usuario ya esta registrado.", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtClave.Text = "";
            txtID.Text = "";
            txtNombre.Text = "";
            cbPrivilegio.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.Close();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber((char)(e.KeyChar)) &&
            (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")) &&
            e.KeyChar != (char)(Keys.Back) &&
            e.KeyChar != (char)(Keys.OemPeriod))
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
                e.KeyChar != ((char)(Keys.Space)) &&
                (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")))
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    txtClave.Focus();
                }
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit((char)(e.KeyChar)) &&
            e.KeyChar == Convert.ToChar(Keys.Enter) &&
            (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")) &&
            e.KeyChar != (char)(Keys.Back) &&
            e.KeyChar != (char)(Keys.OemPeriod))
            {
                e.Handled = true;
                cbPrivilegio.Focus();
            }
        }

        private void cbPrivilegio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnAceptar.Focus();
            }
        }
    }
}
