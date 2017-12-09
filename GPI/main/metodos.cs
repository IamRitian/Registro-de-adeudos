using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace main
{
    class metodos
    {
        BasedeDatos con = new BasedeDatos();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public double obtenerMonto(string Date, int IDEmpleado)
        {
            double r;
            string date = Date;
            int idEmpleado = IDEmpleado;
            con.abrirbd();
            cmd = new SqlCommand("select SUM(Monto) from Adeudo where Fecha='" + date + "' and No_empleado=" + idEmpleado + "", con.conecta);
            dr = cmd.ExecuteReader();
            dr.Read();
            r = double.Parse(dr[0].ToString());
            con.cerrarbd();
            return r;
        }

        public double obtenerTotal(int IDEmpleado)
        {
            double d;
            int id=IDEmpleado;
            con.abrirbd();
            cmd = new SqlCommand("select * from lista_nomina where No_empleado=" + id + "",con.conecta);
            dr = cmd.ExecuteReader();
            dr.Read();
            d = double.Parse(dr[2].ToString()) + double.Parse(dr[3].ToString()) + double.Parse(dr[4].ToString()) + double.Parse(dr[5].ToString()) + double.Parse(dr[6].ToString());
            con.cerrarbd();
            return d;
        }

        public void insertTotal(int IDEmpleado)
        {
            int id = IDEmpleado;
            double t = obtenerTotal(id);
            cmd.CommandText = "update lista_nomina set Total=" + t + " where No_empleado=" + id + "";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.conecta.Open();
            cmd.ExecuteNonQuery();
            con.conecta.Close();

        }

        public void insertmonto(double monto, int IDempleado)
        {
            int id = IDempleado;
            double m = monto;
            
            if (DateTime.Now.DayOfWeek.ToString() == "Monday")
            {
                cmd.CommandText = "update lista_nomina set Lunes=" + m + " where No_empleado=" + id + "";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.conecta;
                con.conecta.Open();
                cmd.ExecuteNonQuery();
                con.conecta.Close();
            }
            else
            {
                if (DateTime.Now.DayOfWeek.ToString() == "Tuesday")
                {
                    cmd.CommandText = "update lista_nomina set Martes=" + m + " where No_empleado=" + id + "";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con.conecta;
                    con.conecta.Open();
                    cmd.ExecuteNonQuery();
                    con.conecta.Close();
                }
                else
                {
                    if (DateTime.Now.DayOfWeek.ToString() == "Wednesday")
                    {
                        cmd.CommandText = "update lista_nomina set Miercoles=" + m + " where No_empleado=" + id + "";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con.conecta;
                        con.conecta.Open();
                        cmd.ExecuteNonQuery();
                        con.conecta.Close();
                    }
                    else
                    {
                        if (DateTime.Now.DayOfWeek.ToString() == "Thursday")
                        {
                            cmd.CommandText = "update lista_nomina set Jueves=" + m + " where No_empleado=" + id + "";
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = con.conecta;
                            con.conecta.Open();
                            cmd.ExecuteNonQuery();
                            con.conecta.Close();
                        }
                        else
                        {
                            if (DateTime.Now.DayOfWeek.ToString() == "Friday")
                            {
                                cmd.CommandText = "update lista_nomina set Viernes=" + m + " where No_empleado=" + id + "";
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = con.conecta;
                                con.conecta.Open();
                                cmd.ExecuteNonQuery();
                                con.conecta.Close();
                            }
                        }

                    }

                }

            }
        }

        public void agregaEmpleado(int ID, string Nombre, int IDdepart, string Codigo)
        {
            int id = ID;
            string nombre = Nombre;
            int idDepart = IDdepart;
            string codigo = Codigo;
            cmd.CommandText = "insert into Empleados values(" + id + ",'" + nombre + "','" + idDepart + "','" + codigo + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.conecta.Open();
            cmd.ExecuteNonQuery();
            con.conecta.Close();
        }
        public void eliminarEmpleado(int ID)
        {
            int id = ID;
            cmd.CommandText = "delete from Empleados where No_empleado=" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.conecta.Open();
            cmd.ExecuteNonQuery();
            con.conecta.Close();
        }
        public void actualizarEmpleado(int ID,string Nombre,int IDdep,int Codigo)
        {
            int id = ID;
            string nombre = Nombre;
            int idde = IDdep;
            int c = Codigo;
            cmd.CommandText = "UPDATE Empleados SET Nombre='" + nombre + "',No_departamento=" + idde + ",codigo =" + c + " where No_empleado =" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.conecta.Open();
            cmd.ExecuteNonQuery();
            con.conecta.Close();
        }
        public void agregaEL(int ID, int IDdepart)
        {
            int id = ID;
            int idDpart = IDdepart;
            cmd.CommandText = "insert into lista_nomina values(" + id + "," + idDpart + ",'','','','','','')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.conecta.Open();
            cmd.ExecuteNonQuery();
            con.conecta.Close();
        }

        public void agregarArticulo(int ID, string Descripcion, double Precio)
        {
            int id = ID;
            string desp = Descripcion;
            double p = Precio;
            cmd.CommandText = "insert into Articulos values(" + id + ",'" + desp + "'," + p + ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.abrirbd();
            cmd.ExecuteNonQuery();
            con.cerrarbd();
        }
        public void eliminarArticulo(int ID)
        {
            int id=ID;
            cmd.CommandText = "delete from Articulos where clave_articulo=" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.abrirbd();
            cmd.ExecuteNonQuery();
            con.cerrarbd();
        }
        public void actualizarArticulo(int ID, string Desc, double Precio)
        {
            int id = ID;
            string d = Desc;
            double p = Precio;
            cmd.CommandText = "update Articulos set Descripcion='" + d + "', Precio=" + p + " where clave_articulo=" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.abrirbd();
            cmd.ExecuteNonQuery();
            con.cerrarbd();
        }
        public void eliminarAP()
        {
            
            cmd.CommandText = "delete from AdeudoPendiente where seleccion='true'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.conecta.Open();
            cmd.ExecuteNonQuery();
            con.conecta.Close();


        }

        public void actualizarAP(string ID, string CLV, string FECHA,string CANT, string MONTO)
        {
            string id = ID;
            string clv = CLV;
            string f = FECHA;
            string c = CANT;
            string m = MONTO;
            cmd.CommandText = "update AdeudoPendiente set seleccion='true' where No_empleado=" + id+" and clave_articulo="+clv+" and Fecha='"+f+"' and Cantidad="+c+" and Monto=" + m;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.conecta.Open();
            cmd.ExecuteNonQuery();
            con.conecta.Close();


        }
        public void actualizarAP1(string ID, string CLV, string FECHA, string CANT, string MONTO)
        {
            string id = ID;
            string clv = CLV;
            string f = FECHA;
            string c = CANT;
            string m = MONTO;
            cmd.CommandText = "update AdeudoPendiente set seleccion='false' where No_empleado=" + id + " and clave_articulo=" + clv + " and Fecha='" + f + "' and Cantidad=" + c + " and Monto=" + m;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.conecta.Open();
            cmd.ExecuteNonQuery();
            con.conecta.Close();
        }
        public void reiniciarAdeudos()
        {

            cmd.CommandText = "UPDATE lista_nomina SET Lunes='', Martes='', Miercoles='', Jueves='', Viernes='',Total=''";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.conecta.Open();
            cmd.ExecuteNonQuery();
            con.conecta.Close();
        }

        public void agregarUsuario(int ID, string Nombre, string Clave, string Nivel)
        {
            int id = ID;
            string nombre = Nombre;
            string clave = Clave;
            string nivel = Nivel;
            cmd.CommandText = "insert into Usuarios values(" + id + ",'" + nombre + "','" + clave + "','" + nivel +"')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.abrirbd();
            cmd.ExecuteNonQuery();
            con.cerrarbd();
        }
        public void eliminarUsuario(int ID)
        {
            int id = ID;
            cmd.CommandText = "delete from Usuarios where IDusuario=" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.conecta.Open();
            cmd.ExecuteNonQuery();
            con.conecta.Close();
        }
        public void actualizarUsuario(int ID, string Nombre, string Clave, string Nivel)
        {
            int id = ID;
            string nombre = Nombre;
            string clave = Clave;
            string nivel = Nivel;
            cmd.CommandText = "UPDATE Usuarios SET Nombre='" + nombre + "',clave='" + clave + "' ,Nivel='" + nivel + "' where IDusuario=" + id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conecta;
            con.conecta.Open();
            cmd.ExecuteNonQuery();
            con.conecta.Close();
        }
    }
}
