using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace main.Listas
{
    public partial class Lista_de_Nomina : Form
    {
        public Lista_de_Nomina()
        {
            InitializeComponent();
        }

        private void Lista_de_Nomina_Load(object sender, EventArgs e)
        {
            DataSetTabla t = new DataSetTabla();
            BasedeDatos bd = new BasedeDatos();
            SqlDataAdapter da = new SqlDataAdapter("select * from list_nomina",bd.conecta);
            da.Fill(t, t.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("Lista_Nomina",t.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();
            
            this.reportViewer1.RefreshReport();

            
        }

        private void reportViewer1_Print(object sender, ReportPrintEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea reiniciar el registro de TODOS los adeudos?", "Reiniciar Adeudos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                metodos m = new metodos();
                m.reiniciarAdeudos();
            }
            else if (dialogResult == DialogResult.No)
            {//do something else
            }

        }

        private void reportViewer1_ReportExport(object sender, ReportExportEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea reiniciar el registro de TODOS los adeudos?", "Reiniciar Adeudos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                metodos m = new metodos();
                m.reiniciarAdeudos();
            }
            else if (dialogResult == DialogResult.No)
            {//do something else
            }

        }
    }
}
