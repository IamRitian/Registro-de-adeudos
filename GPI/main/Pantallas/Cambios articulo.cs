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
    public partial class Cambios_articulo : Form
    {
        public Cambios_articulo()
        {
            InitializeComponent();
        }
        BasedeDatos con = new BasedeDatos();

        private void btnID_Click(object sender, EventArgs e)
        {
            PantallasExtra.listaAC la = new PantallasExtra.listaAC();
            la.ShowDialog();

            if (la.DialogResult==DialogResult.OK)
            {
                txtIDarticulo.Text = la.idArticulo;
                txtDesc.Text = la.desc;
                txtPrecio.Text = la.precio;
            }
        }

        private void txtIDarticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && !string.IsNullOrEmpty(txtIDarticulo.Text))
                    {
                        e.Handled = true;

                        con.abrirbd();
                        SqlCommand cmd = new SqlCommand("select Descripcion, Precio from Articulos where clave_articulo=" + txtIDarticulo.Text + "", con.conecta);
                        SqlDataReader dr1 = cmd.ExecuteReader();
                        if (dr1.Read())
                        {
                            txtDesc.Text = dr1[0].ToString();
                            txtPrecio.Text = dr1[1].ToString();
                            dr1.Close();
                            con.cerrarbd();
                            txtDesc.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Tecle ID del articulo para continuar.");
                    }
                }
            }catch(Exception ex) { }
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                txtPrecio.Focus();
            }

            }
            
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit((char)(e.KeyChar)) &&
            e.KeyChar == Convert.ToChar(Keys.Enter) &&
            e.KeyChar != (char)(Keys.Delete) &&
            e.KeyChar != (char)(Keys.Back) &&
            e.KeyChar != (char)(Keys.OemPeriod))
            {
                e.Handled = true;
                btnCambiar.Focus();
                
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtIDarticulo.Text)
                    || !!string.IsNullOrEmpty(txtDesc.Text)
                    || !string.IsNullOrEmpty(txtPrecio.Text))
                {
                    metodos m = new metodos();
                    int id = int.Parse(txtIDarticulo.Text);
                    string desc = txtDesc.Text;
                    double p = int.Parse(txtPrecio.Text);
                    m.actualizarArticulo(id, desc, p);
                    limpiar();
                    MessageBox.Show("Datos del artículo actualizado.");
                    this.Hide();
                }
                else { MessageBox.Show("Uno o dos campos del formulario estan vacios."); }

            }
            catch (Exception ex) { MessageBox.Show("Error al actualizar datos. " + ex.ToString()); }
        }

        public void limpiar()
        {
            txtDesc.Text = "";
            txtIDarticulo.Text = "";
            txtPrecio.Text = "";
        }

    }
}
