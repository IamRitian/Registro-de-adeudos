using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace main
{
    class BasedeDatos
    {
        public SqlConnection conecta = new SqlConnection("Data Source=DARKNESS-PC;Initial Catalog=GPIserver;Integrated Security=True");
        SqlCommandBuilder cmb;
        DataSet ds;
        SqlDataAdapter da;
        SqlCommand comando;
        DataTable dt;
        SqlDataReader dr;
        string cadena = string.Empty;


        public void abrirbd()
        {
            try
            {
                conecta.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al abrir Base de datos: " + ex.ToString());
            }
        }

        public void cerrarbd()
        {
            try
            {
                conecta.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("error al cerrar Base de datos: " + ex.ToString());
            }

        }

        public string selectstring(string query)
        {

            try
            {
                abrirbd();
                comando = new SqlCommand(query, conecta);
                cadena = comando.ExecuteScalar().ToString();
            }
            catch (Exception)
            {

                cadena = string.Empty;
            }
            finally { cerrarbd(); }
            return cadena;
        }
        //public string selectstring1(string query)
        //{
        //    string cadena = string.Empty;
        //    try
        //    {
        //        abrirbd();
        //        comando = new SqlCommand(query, conecta);
        //        cadena = comando.ExecuteScalar().ToString();
        //    }
        //    catch (Exception)
        //    {

        //        cadena = string.Empty;
        //    }
        //    finally { cerrarbd(); }
        //    return cadena;
        //}

        public void consulta(string query, string tabla)
        {
            ds = new DataSet();
            ds.Tables.Clear();
            da = new SqlDataAdapter(query, conecta);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public void cargarArticulos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from tabla_articulo", conecta);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudó obtener la tabla de artículos. por el siguiente error:" + e.ToString());
            }
        }
        public void cargarA(DataGridView dgv, ComboBox cb, TextBox txt)
        {
            if (cb.SelectedIndex == 0)
            {
                try
                {
                    da = new SqlDataAdapter("select * from tabla_articulo where Descripcion like '%" + txt.Text + "%'", conecta);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se pudó obtener la tabla de artículos. por el siguiente error:" + e.ToString());
                }
            }
            else
            {
                if (cb.SelectedIndex == 1)
                {
                    try
                    {
                        da = new SqlDataAdapter("select * from tabla_articulo where Descripcion like '%" + txt.Text + "%' Order by Precio asc", conecta);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("No se pudó obtener la tabla de artículos. por el siguiente error:" + e.ToString());
                    }
                }
                else
                {
                    if (cb.SelectedIndex == 2)
                    {
                        try
                        {
                            da = new SqlDataAdapter("select * from tabla_articulo where Descripcion like '%" +txt.Text+"%' order by Precio desc", conecta);
                            dt = new DataTable();
                            da.Fill(dt);
                            dgv.DataSource = dt;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("No se pudó obtener la tabla de artículos. por el siguiente error:" + e.ToString());
                        }
                    }
                }
                }

            }
        

        public void cargarEmpleado(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from tabla_empleado", conecta);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudó obtener la tabla de empleados. por el siguiente error:" + e.ToString());
            }
        }
        public void cargarE1(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from Empleados", conecta);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudó obtener la tabla de empleados. por el siguiente error:" + e.ToString());
            }
        }
        public void cargarE12(DataGridView dgv, ComboBox cb, TextBox txt)
        {
            if (cb.SelectedIndex==0)
            {
                try
                {
                    da = new SqlDataAdapter("select * from Empleados where Nombre like '%" + txt.Text +"%'", conecta);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se pudó obtener la tabla de empleados. por el siguiente error:" + e.ToString());
                }
            }
            else
            {
                if (cb.SelectedIndex==1)
                {
                    try
                    {
                        da = new SqlDataAdapter("select * from Empleados where No_empleado=" + txt.Text, conecta);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("No se pudó obtener la tabla de empleados. por el siguiente error:" + e.ToString());
                    }
                }
                
            }
        }

        public void cargarE(DataGridView dgv, ComboBox cb, TextBox txt)
        {
            if (cb.SelectedIndex == 0)
            {
                try
                {
                    da = new SqlDataAdapter("select * from tabla_empleado where Nombre like '%" + txt.Text + "%'", conecta);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se pudó obtener la tabla de empleados. por el siguiente error:" + e.ToString());
                }
            }
            else
            {
                if (cb.SelectedIndex == 1)
                {
                    try
                    {
                        da = new SqlDataAdapter("select * from tabla_empleado where  No_empleado =" + txt.Text, conecta);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("No se pudó obtener la tabla de empleados. por el siguiente error:" + e.ToString());
                    }
                }
                else
                {
                    if (cb.SelectedIndex == 2)
                    {
                        try
                        {
                            da = new SqlDataAdapter("select * from tabla_empleado where Departamento like '%" + txt.Text + "%'", conecta);
                            dt = new DataTable();
                            da.Fill(dt);
                            dgv.DataSource = dt;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("No se pudó obtener la tabla de empleados. por el siguiente error:" + e.ToString());
                        }
                    }

                }

            }
        }


        public void cargarDepartamento(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from tabla_departamento", conecta);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudó obtener la tabla de departamento. por el siguiente error:" + e.ToString());
            }
        }
        public void cargarD(DataGridView dgv, ComboBox cb, TextBox txt)
        {
            if (cb.SelectedIndex == 0)
            {
                try
                {
                    da = new SqlDataAdapter("select * from tabla_departamento where Departamento like '%" + txt.Text + "%'", conecta);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se pudó obtener la tabla de departamento. por el siguiente error:" + e.ToString());
                }
                if (cb.SelectedIndex==1)
                {
                    try
                    {
                        da = new SqlDataAdapter("select * from tabla_departamento where No_departamento=" + txt.Text, conecta);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("No se pudó obtener la tabla de departamento. por el siguiente error:" + e.ToString());
                    }
                }
            }
        }

        public void cargarAdeudoPend(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from tabla_ap", conecta);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudó obtener la tabla de adeudo pendiente. por el siguiente error:" + e.ToString());
            }
        }
        public void cargarAdeudoP(DataGridView dgv, ComboBox cb, TextBox txt)
        {
            if (cb.SelectedIndex == 0)
            {
                try
                {
                    da = new SqlDataAdapter("select * from tabla_ap where Nombre like '%" + txt.Text + "%'", conecta);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se pudó obtener la tabla de adeudo pendiente. por el siguiente error:" + e.ToString());
                }
            }
            else { 
                if (cb.SelectedIndex== 1)
                {
                    try
                    {
                        da = new SqlDataAdapter("select * from tabla_ap where No_empleado=" + txt.Text, conecta);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("No se pudó obtener la tabla de adeudo pendiente. por el siguiente error:" + e.ToString());
                    }
                    
                }
            }
        }

        public void cargarUsuario(DataGridView dgv, ComboBox cb, TextBox txt)
        {
            if (cb.SelectedIndex == 0)
            {
                try
                {
                    da = new SqlDataAdapter("select * from Usuarios where Nombre like '%" + txt.Text + "%'", conecta);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgv.DataSource = dt;
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se pudó obtener la tabla de adeudo pendiente. por el siguiente error:" + e.ToString());
                }
            }
            else
            {
                if (cb.SelectedIndex == 1)
                {
                    try
                    {
                        da = new SqlDataAdapter("select * from Usuarios where IDusuario=" + txt.Text, conecta);
                        dt = new DataTable();
                        da.Fill(dt);
                        dgv.DataSource = dt;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("No se pudó obtener la tabla de adeudo pendiente. por el siguiente error:" + e.ToString());
                    }

                }
            }
        }

        public void cargarUsuario(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("select * from Usuarios", conecta);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudó obtener la tabla de departamento. por el siguiente error:" + e.ToString());
            }
        }

        public void aC(TextBox txt)
        {
            try
            {
                abrirbd();
                comando = new SqlCommand("Select * from tabla_ap",conecta);
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    txt.AutoCompleteCustomSource.Add(dr["Nombre"].ToString());
                }
                dr.Close();
                cerrarbd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo auto completar. "+ex.ToString());
                
            }
        }
        //public bool insertar(string sql)
        //{
        //    conecta.Open();
        //    comando = new SqlCommand(sql, conecta);
        //    int i = comando.ExecuteNonQuery();
        //    if (i > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
