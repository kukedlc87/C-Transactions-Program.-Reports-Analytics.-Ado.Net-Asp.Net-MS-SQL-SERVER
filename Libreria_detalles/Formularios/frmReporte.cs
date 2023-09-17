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

namespace Libreria_detalles.Reporte
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void reporte_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            Conexion cnn = new Conexion();
            DataTable dt = new DataTable();
            SqlParameter par;
            List<SqlParameter> list = new List<SqlParameter>();
            string desde = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string hasta = dateTimePicker2.Value.ToString("yyyy-MM-dd");


            par = new SqlParameter("@desde", SqlDbType.DateTime);
            par.Value = desde;
            list.Add(par);

            par = new SqlParameter("@hasta", SqlDbType.DateTime);
            par.Value = hasta;
            list.Add(par);

            dt = cnn.ReaderSP("SP_Informe", list);
            sPInformeBindingSource.DataSource = dt;
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
