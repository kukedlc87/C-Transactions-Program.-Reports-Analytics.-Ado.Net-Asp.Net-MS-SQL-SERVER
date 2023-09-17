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

namespace Libreria_detalles
{
    public partial class Nuevo_articulo : Form
    {
        public Nuevo_articulo()
        {
            InitializeComponent();
        }

        private void Nuevo_articulo_Load(object sender, EventArgs e)
        {
            CargarData();
        }

        public void CargarData()
        {
            string query = "select * from articulos";
            Conexion cnn = new Conexion();
            DataTable dt = cnn.Reader(query);
            dataGridView1.DataSource = dt;
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            Articulos art = new Articulos();
           
            art.Pre_unitario = Convert.ToInt32(textBox2.Text);
            art.Descripcion = textBox1.Text;
            int stock = Convert.ToInt32(textBox3.Text);

            SqlParameter p = new SqlParameter();
            List<SqlParameter> sp = new List<SqlParameter>();

            p = new SqlParameter("@Descripcion", SqlDbType.VarChar);
            p.Value = art.Descripcion;
            sp.Add(p);

            p = new SqlParameter("@stock", SqlDbType.Int);
            p.Value = stock;
            sp.Add(p);

            p = new SqlParameter("@Pre_unitario", SqlDbType.Int);
            p.Value = art.Pre_unitario;
            sp.Add(p);

            Conexion conexion = new Conexion();
            conexion.Agregar("SP_Articulo_nuevo", sp);

            CargarData();
        }
    }
}
