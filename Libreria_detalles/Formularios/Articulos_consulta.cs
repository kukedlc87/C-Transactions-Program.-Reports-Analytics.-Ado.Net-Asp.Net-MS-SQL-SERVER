using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Libreria_detalles
{
    public partial class Articulos_consulta : Form
    {
        public Articulos_consulta()
        {
            InitializeComponent();
            CustomizeDataGridViewAppearance();
        }

        private void CustomizeDataGridViewAppearance()
        {
            // Personaliza la apariencia visual del DataGridView
            dataGridView1.BackgroundColor = Color.LightGray; // Cambia el color de fondo del DataGridView
            dataGridView1.DefaultCellStyle.BackColor = Color.White; // Cambia el color de fondo de las celdas
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Cambia el color del texto de las celdas
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12); // Cambia la fuente de las celdas

            // Cambia el color de fondo y el color del texto de las celdas seleccionadas
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Personaliza la apariencia de las filas alternas
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray; // Cambia el color de fondo de las filas alternas
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // Cambia el color de fondo de las filas no alternas
        }

        private void Articulos_consulta_Load(object sender, EventArgs e)
        {
            Conexion cnn = new Conexion();
            DataTable dt = new DataTable();
            dt = cnn.Reader("SP_Articulos");
            dataGridView1.DataSource = dt;
        }
    }
}
