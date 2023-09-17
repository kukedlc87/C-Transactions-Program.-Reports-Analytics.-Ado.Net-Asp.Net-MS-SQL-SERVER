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

namespace Libreria_detalles.Formularios
{
    public partial class frmConsultarVentas : Form
    {
        public frmConsultarVentas()
        {
            InitializeComponent();
        }

        private void dataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            { 
                int numeroFactura = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

                using (SqlConnection connection = new SqlConnection(@"Data Source=kuke;Initial Catalog=LIBRERIA;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("borrar_factura", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nro_factura", numeroFactura);

                    cmd.ExecuteNonQuery();
                    CArgar();
           

                }
            }
        }

        private void frmConsultarVentas_Load(object sender, EventArgs e)
        {
            CArgar();
        }

        private void CArgar()
        {
            this.sp_traerFacturasTableAdapter.Fill(this.dataSet1.sp_traerFacturas, null);

            // Agregar una columna de botones "Borrar" en la cuarta posición (índice 3)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["ColBorrar"].Value = "Quitar"; // Asignar "Quitar" a la celda de botón en cada fila
            }
        }
    }
}
