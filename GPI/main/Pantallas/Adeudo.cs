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
using Microsoft.Reporting.WinForms;

namespace main.Pantallas
{
    public partial class Adeudo : Form
    {
        public Adeudo()
        {
            InitializeComponent();
        }
        public Adeudo(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        int id;

        private void Adeudo_Load(object sender, EventArgs e)
        {
            DataSetTabla t = new DataSetTabla();
            BasedeDatos bd = new BasedeDatos();
            SqlDataAdapter da = new SqlDataAdapter("select * from list_nomina where No_empleado="+id, bd.conecta);
            da.Fill(t, t.Tables[0].TableName);
            ReportDataSource rds = new ReportDataSource("Lista_Nomina", t.Tables[0]);
            Listas.Lista_de_Nomina ln = new Listas.Lista_de_Nomina();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }
        
    }
}
