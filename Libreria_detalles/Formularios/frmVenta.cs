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
    public partial class frmVenta : Form
    {
        Factura nueva;
        public frmVenta()
        {
            InitializeComponent();
            nueva = new Factura();

        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarCombo1();
            CargarCombo2();
        }

        private void CargarCombo()
        {
            string query = "select * from Clientes";
            Conexion cnn = new Conexion();
            DataTable dt = new DataTable();
            dt = cnn.Reader(query);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "cod_cliente";
            comboBox1.DisplayMember = "nom_cliente";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarCombo2()
        {
            string query = "select * from Vendedores";
            Conexion cnn = new Conexion();
            DataTable dt = new DataTable();
            dt = cnn.Reader(query);
            comboBox3.DataSource = dt;
            comboBox3.ValueMember = "cod_vendedor";
            comboBox3.DisplayMember = "nom_vendedor";
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarCombo1()
        {
            string query = "select * from Articulos";
            Conexion cnn = new Conexion();
            DataTable dt = new DataTable();
            dt = cnn.Reader(query);
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = "cod_articulo";
            comboBox2.DisplayMember = "descripcion";
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
          
           
            

            //SqlParameter p;
            //List<SqlParameter> list = new List<SqlParameter>();
            //p = new SqlParameter("@fecha", SqlDbType.DateTime);
            //p.Value = DateTime.Now;
            //list.Add(p);

            //p = new SqlParameter("@cod_cliente", SqlDbType.Int);
            //p.Value = nueva.Cod_cliente;
            //list.Add(p);

            //p = new SqlParameter("@cod_vendedor", SqlDbType.Int);
            //p.Value = nueva.Cod_vendedor;
            //list.Add(p);

            //Conexion conexion = new Conexion();
            //conexion.Agregar("nueva_factura", list);

            //int algo = 0;

            //algo = conexion.UltimoId();
            //MessageBox.Show(Convert.ToString(algo));




        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["cl_Descripccion"].Value == (comboBox2.Text))
                {
                    MessageBox.Show("Ya esta agregado este articulo");
                    return;


                }

            }

            DataRowView item = (DataRowView)comboBox2.SelectedItem;

            int nro = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            double pre = Convert.ToDouble(item.Row.ItemArray[4]);

            Articulos arti = new Articulos(nom, pre, nro);

            int cant = (int)numericUpDown1.Value;
            double subtotal = cant * arti.Pre_unitario;

            Detalle detalle = new Detalle(arti, cant);

            dataGridView1.Rows.Add(new object[] { nom, pre, cant, subtotal, "Quitar" });

           
            nueva.AgregarDetalles(detalle);

            double total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               
                total += Convert.ToDouble(row.Cells[3].Value);

            }

            label1.Text = "Total: " + total.ToString();
        }

        private void BtnConfirmar_Click_1(object sender, EventArgs e)
        {
            nueva.Fecha = DateTime.Now;
            nueva.Cod_cliente = Convert.ToInt32(comboBox1.SelectedValue);
            nueva.Cod_vendedor = Convert.ToInt32(comboBox3.SelectedValue);
            Conexion conexion = new Conexion();
            conexion.ConfirmarFactura(nueva);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
