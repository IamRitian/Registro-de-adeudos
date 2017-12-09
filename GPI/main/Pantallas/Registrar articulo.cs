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
    public partial class Registrar_articulo : Form
    {
        public Registrar_articulo()
        {
            InitializeComponent();
        }

        metodos m = new metodos();
        BasedeDatos con = new BasedeDatos();
        SqlDataReader dr = null;
        SqlCommand cmd;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            limpiar();
        }

        
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescripcion.Text) ||
                !string.IsNullOrEmpty(txtIDarticulo.Text) ||
                !string.IsNullOrEmpty(txtPrecio.Text)
                )
            { try
                {
                con.abrirbd();
                SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Articulos where Descripcion like '%" + txtDescripcion.Text + "%'", con.conecta);
                DataTable tabla = new DataTable();
                a.Fill(tabla);
                con.cerrarbd();
                    if (tabla.Rows.Count == 0)
                    {
                        m.agregarArticulo(int.Parse(txtIDarticulo.Text), txtDescripcion.Text, double.Parse(txtPrecio.Text));

                        limpiar();
                        DialogResult dialogResult = MessageBox.Show("Articulo agregado correctamente. ¿Desea agregar otro articulo?", "Capturar articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (dialogResult == DialogResult.Yes)
                        {
                            txtIDarticulo.Focus();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            this.Hide();
                        }
                    }else if (tabla.Rows[0][1].ToString() == txtDescripcion.Text)
                    {
                        limpiar();
                        txtIDarticulo.Focus();
                        MessageBox.Show("Este artículo ya esta registrado.");
                    }
                    
                }
                catch (Exception ex)
                {
                    con.cerrarbd();  MessageBox.Show("No se puede acceder a base de datos." + ex.ToString());
                }
            }
            else { MessageBox.Show("Uno o dos campos estan vacios."); }
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit((char)(e.KeyChar)) &&
           (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")) &&
           e.KeyChar != (char)(Keys.Back) &&
           e.KeyChar != (char)(Keys.OemPeriod)
           )
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    txtDescripcion.Focus();
                }
                

            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ((char)(Keys.Space)))
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    txtPrecio.Focus();
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit((char)(e.KeyChar)) &&
            (e.KeyChar != (char)(Keys.Delete)) &&
            e.KeyChar != (char)(Keys.Back) &&
            e.KeyChar != (char)(Keys.OemPeriod))
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnAceptar.Focus();
                }
                
            }
        }

        public void limpiar()
        {
            txtPrecio.Text = "";
            txtIDarticulo.Text = "";
            txtDescripcion.Text = "";
        }

        private void Registrar_articulo_Load(object sender, EventArgs e)
        {

        }
    }
}
