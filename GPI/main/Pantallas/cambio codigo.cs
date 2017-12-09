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
    public partial class cambio_codigo : Form
    {
        public cambio_codigo()
        {
            InitializeComponent();
        }
        BasedeDatos bd = new BasedeDatos();
        SqlCommand n;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try { 
            bd.abrirbd();
            SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Empleados where No_empleado="+txtID.Text+" and Codigo=" + txtCodAct.Text, bd.conecta);
            DataTable tabla = new DataTable();
            a.Fill(tabla);
                bd.cerrarbd();
                try
                {
                    if ((tabla.Rows[0][0].ToString() == txtID.Text) && (tabla.Rows[0][3].ToString() == txtCodAct.Text))
                    {

                        n = new SqlCommand();
                        n.CommandText = "UPDATE Empleados SET Codigo=" + txtCodNue.Text + " where No_empleado=" + txtID.Text + "";
                        n.CommandType = CommandType.Text;
                        n.Connection = bd.conecta;
                        bd.abrirbd();
                        n.ExecuteNonQuery();
                        bd.cerrarbd();
                        clear();
                        MessageBox.Show("Se cambio codigo correctamente.");
                        this.Hide();
                    }
                    else { MessageBox.Show("Error al cambiar codigo, ID empleado o codigo erroneo."); }
                }
                catch (Exception ex) { MessageBox.Show("Error al cambiar codigo, ID empleado o codigo erroneo."); }
            }
            catch(Exception ex) { bd.cerrarbd(); MessageBox.Show("Fallo en la conexión a base de datos"); }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse("."))
            {
                e.Handled = true;
                if(e.KeyChar == Convert.ToChar(Keys.Enter))
                txtCodAct.Focus();
                
            }
        }

        private void txtCodAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' &&  e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse("."))
            {
                e.Handled = true;
                if(e.KeyChar == Convert.ToChar(Keys.Enter))
                txtCodNue.Focus();
            }
        }

        private void txtCodNue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse("."))
            {
                e.Handled = true;
                if(e.KeyChar == Convert.ToChar(Keys.Enter))
                btnAceptar.Focus();
            }
        }

        public void clear()
        {
            txtID.Text = "";
            txtCodAct.Text = "";
            txtCodNue.Text = "";
        }

        private void cambio_codigo_Load(object sender, EventArgs e)
        {
            txtID.Focus();
        }
    }
}
