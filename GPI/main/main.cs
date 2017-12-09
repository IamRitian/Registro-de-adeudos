using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void registroAdeudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.Registro_de_adeudos ra = new Pantallas.Registro_de_adeudos();
            ra.MdiParent = this;
            ra.Show();
        }

        private void listaDeNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listas.Lista_de_Nomina ln = new Listas.Lista_de_Nomina();
            ln.MdiParent = this;
            ln.Show();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.Registrar_empleado re = new Pantallas.Registrar_empleado();
            re.MdiParent = this;
            re.Show();
        }

        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.Eliminar_Empleado ee = new Pantallas.Eliminar_Empleado();
            ee.MdiParent = this;
            ee.Show();
        }

        private void cambioDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.Cambios_empleado ce = new Pantallas.Cambios_empleado();
            ce.MdiParent = this;
            ce.Show();
        }

        private void cambioCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.cambio_codigo cc = new Pantallas.cambio_codigo();
            cc.MdiParent = this;
            cc.Show();
        }

        private void agregarArticuloToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Pantallas.Registrar_articulo ra = new Pantallas.Registrar_articulo();
            ra.MdiParent = this;
            ra.Show();
        }

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.Eliminar_articulo ea = new Pantallas.Eliminar_articulo();
            ea.MdiParent = this;
            ea.Show();
            
        }

        private void cambiosArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.Cambios_articulo ca = new Pantallas.Cambios_articulo();
            ca.MdiParent = this;
            ca.Show();
        }

        private void adeudosPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.Adeudo_pendiente ap = new Pantallas.Adeudo_pendiente();
            ap.MdiParent = this;
            ap.Show();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pantallas.AgregarUsuario agreUsuario = new Pantallas.AgregarUsuario();
            agreUsuario.MdiParent = this;
            agreUsuario.Show();
        }
    }
}
