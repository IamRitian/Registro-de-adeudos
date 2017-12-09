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

namespace main
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        BasedeDatos bd = new BasedeDatos();
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            logear(txtIDusuario.Text,txtClave.Text);
        }
        public void logear(string ID, string Clave)
        {
            main main = new main();
            Pantallas.Adeudo_pendiente ade = new Pantallas.Adeudo_pendiente();
            try
            {
                bd.abrirbd();
                SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Usuarios where IDusuario=" + txtIDusuario.Text + " and clave='" + txtClave.Text + "'",bd.conecta);
                DataTable dt = new DataTable();
                a.Fill(dt);
                bd.cerrarbd();
                
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][3].ToString()=="Configurador")
                    {
                        main.Show();
                    }
                    else if (dt.Rows[0][3].ToString() == "Administrador")
                    {
                        main.Show();
                        main.administracionDeUsuariosToolStripMenuItem.Enabled = false;
                        //ade.btnEliminar.Enabled = false;
                    }
                    else if (dt.Rows[0][3].ToString() == "Operador")
                    {
                        main.Show();
                        main.mantenimientoToolStripMenuItem.Enabled = false;
                        main.administracionDeUsuariosToolStripMenuItem.Enabled = false;
                        ade.btnEliminar.Enabled = false;
                    }
                }
                else { MessageBox.Show("Usuario y/o Contraseña Incorrecta."); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIDusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber((char)(e.KeyChar)) &&
            (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")) &&
            e.KeyChar != (char)(Keys.Back) &&
            e.KeyChar != (char)(Keys.OemPeriod))
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
            if (!char.IsNumber((char)(e.KeyChar)) &&
            (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")) &&
            e.KeyChar != (char)(Keys.Back) &&
            e.KeyChar != (char)(Keys.OemPeriod))
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnIniciarSesion.Focus();
                }
            }
        }
    }
}
