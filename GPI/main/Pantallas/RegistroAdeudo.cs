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
    public partial class RegistroAdeudo : Form
    {
        public RegistroAdeudo()
        {
            InitializeComponent();
        }
        BasedeDatos con = new BasedeDatos();
        SqlCommand cmd = new SqlCommand();
        metodos m = new metodos();

        int clave;
        string desc;
        int cant;
        double precio;
        int poc;

       
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Adeudo_pendiente ade = new Adeudo_pendiente();
            double monto = 0;
            if (DGVlistA.RowCount == 0)
            {
                MessageBox.Show("No hay articulo(s) registrado.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtIDempleado.Text) || string.IsNullOrEmpty(txtCod.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboDepartamento.Text))
                {
                    MessageBox.Show("Uno o varios campos vacios, llenelos para registrar.");
                }
                else
                {
                    try
                    {
                        con.abrirbd();
                        SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM Empleados where No_empleado=" + txtIDempleado.Text + " and Codigo=" + txtCod.Text, con.conecta);
                        DataTable tabla = new DataTable();
                        a.Fill(tabla);
                        con.cerrarbd();
                        try
                        {
                            if ((tabla.Rows[0][0].ToString() == txtIDempleado.Text) && (tabla.Rows[0][3].ToString() == txtCod.Text))
                            {
                                for (int i = 0; i < DGVlistA.RowCount; ++i)
                                {
                                    clave = int.Parse(DGVlistA.Rows[i].Cells[0].Value.ToString());
                                    desc = DGVlistA.Rows[i].Cells[1].Value.ToString();
                                    cant = int.Parse(DGVlistA.Rows[i].Cells[2].Value.ToString());
                                    precio = double.Parse(DGVlistA.Rows[i].Cells[3].Value.ToString());

                                    cmd.CommandText = "insert into Adeudo values(" + txtIDempleado.Text + "," + clave + ",'" + lblTimer.Text + "'," + cant + ", " + precio + ",'true','false')";
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Connection = con.conecta;

                                    con.abrirbd();
                                    cmd.ExecuteNonQuery();
                                    con.conecta.Close();

                                    monto = m.obtenerMonto(DateTime.Now.ToString("yyyy/MM/dd"), int.Parse(txtIDempleado.Text));
                                    m.insertmonto(monto, int.Parse(txtIDempleado.Text));
                                    m.insertTotal(int.Parse(txtIDempleado.Text));
                                    m.eliminarAP();
                                }
                                limpiar();
                                MessageBox.Show("Se agregó adeudo correctamente.");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("El Codigo esta incorrecto.");
                        }

                    }
                    catch (Exception) { MessageBox.Show("Error al conectar base de datos"); }
                }
            }
            ade.DGVAdeudoP.Refresh();
            this.Hide();
        }


        public void limpiar()
        {
            txtIDempleado.Text = "";
            txtNombre.Text = "";
            cboDepartamento.Text = "";
            DGVlistA.Rows.Clear();
            txtCod.Text = "";
        }
        public void limpiarA()
        {
            txtCLV.Text = "";
            txtCant.Text = "";
            txtDesp.Text = "";
            txtPrecio.Text = "";
        }

        private void RegistroAdeudo_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            txtIDempleado.Focus();
        }

        private void txtIDempleado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && !string.IsNullOrEmpty(txtIDempleado.Text))
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {


                    con.abrirbd();
                    SqlCommand cmd = new SqlCommand("select No_empleado, Nombre, Departamentos.Departamento, Codigo from (Empleados inner join Departamentos on Departamentos.No_departamento = Empleados.No_departamento) where No_empleado=" + txtIDempleado.Text + "", con.conecta);
                    SqlDataReader dr1 = cmd.ExecuteReader();
                    if (dr1.Read())
                    {
                        txtNombre.Text = dr1[1].ToString();
                        cboDepartamento.Text = dr1[2].ToString();
                        dr1.Close();
                        con.cerrarbd();
                        txtCLV.Focus();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Empleado no registrado, deseas registrar empleado?", "Capturar empleado", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Registrar_empleado re = new Registrar_empleado();
                            re.Show();
                            con.cerrarbd();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            con.cerrarbd();
                        }
                    }

                }
                else { MessageBox.Show("Ingrese ID del empleado para poder registar.", "Error"); }

            }
        }

        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Listas.lista_empleado le = new Listas.lista_empleado();
            le.ShowDialog();

            if (le.DialogResult == DialogResult.OK)
            {
                txtIDempleado.Text = le.id;
                txtNombre.Text = le.nom;
                cboDepartamento.Text = le.dept;
            }
        }

        private void txtCLV_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber((char)(e.KeyChar)) &&
            (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")) &&
            e.KeyChar != (char)(Keys.Back) &&
            e.KeyChar != (char)(Keys.OemPeriod) &&
            e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                if (!string.IsNullOrEmpty(txtCLV.Text))
                {
                    try
                    {
                        con.abrirbd();
                        SqlCommand cmd = new SqlCommand("select * from Articulos where clave_articulo=" + txtCLV.Text + "", con.conecta);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {

                            txtDesp.Text = dr[1].ToString();
                            txtPrecio.Text = dr[2].ToString();
                            dr.Close();
                            con.cerrarbd();
                            txtCant.Focus();
                        }
                        else
                        {
                            con.cerrarbd();
                            MessageBox.Show("Error articulo ingresado no existe.", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        con.cerrarbd();
                        MessageBox.Show("No se pudo conectar a base de datos. " + ex.ToString());
                    }
                }
                else
                { MessageBox.Show("Ingrese clave de articulo para continuar.", "Error"); }
            }
        }

        private void DGVlistA_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            poc = DGVlistA.CurrentRow.Index;
            //txtCant.Text = DGVlistA[2, poc].Value.ToString();
            txtCLV.Text = DGVlistA.CurrentRow.Cells[0].Value.ToString();
            txtDesp.Text = DGVlistA.CurrentRow.Cells[1].Value.ToString();
            txtCant.Text = DGVlistA.CurrentRow.Cells[2].Value.ToString();
            con.abrirbd();
            SqlCommand cmd = new SqlCommand("select * from Articulos where clave_articulo=" + txtCLV.Text + "", con.conecta);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtPrecio.Text = dr[2].ToString();
                con.cerrarbd();
            }
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtCant.Focus();
        }

        private void txtCant_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b' && !string.IsNullOrEmpty(txtCant.Text) && e.KeyChar == Convert.ToChar(Keys.Enter) && e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse("."))
            {
                e.Handled = true;
                con.abrirbd();
                SqlCommand cmd = new SqlCommand("select * from Articulos where clave_articulo=" + txtCLV.Text + "", con.conecta);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    double a = double.Parse(dr[2].ToString());
                    double b = a * int.Parse(txtCant.Text);
                    DGVlistA.Rows.Add(txtCLV.Text, dr[1].ToString(), txtCant.Text, b);
                    txtCLV.Text = "";
                    txtCant.Text = "";
                    txtPrecio.Text = "";
                    txtDesp.Text = "";
                    dr.Close();
                    con.cerrarbd();
                    txtCLV.Focus();
                }
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            limpiar();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            string c, p;
            double a;
            p = txtPrecio.Text;
            c = txtCant.Text;
            a = int.Parse(c) * double.Parse(p);
            DGVlistA[2, poc].Value = c;
            DGVlistA[3, poc].Value = a;
            txtCLV.Text = "";
            txtCant.Text = "";
            txtPrecio.Text = "";
            txtDesp.Text = "";
            txtCLV.Focus();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int fila = DGVlistA.CurrentRow.Index;
            DGVlistA.Rows.RemoveAt(fila);
            limpiarA();
        }

        private void txtCod_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber((char)(e.KeyChar)) &&
            (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")) &&
            e.KeyChar != (char)(Keys.Back) &&
            e.KeyChar != (char)(Keys.OemPeriod))
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnRegistrar.Focus();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Listas.lista_articulos la = new Listas.lista_articulos();
            la.ShowDialog();
            if (la.DialogResult == DialogResult.OK)
            {
                txtCLV.Text = la.clv;
                txtDesp.Text = la.desp;
                txtPrecio.Text = la.p;
                txtCant.Focus();
            }
        }
    }
}
