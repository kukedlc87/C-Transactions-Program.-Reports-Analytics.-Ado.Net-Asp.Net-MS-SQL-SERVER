using Libreria_detalles.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Libreria_detalles.Formularios;

namespace Libreria_detalles
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta fr = new frmVenta();
            fr.ShowDialog();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Articulos_consulta ar = new Articulos_consulta();
            ar.ShowDialog();
        }

        private void agregarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Nuevo_articulo nv = new Nuevo_articulo();
            nv.ShowDialog();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporte fr = new frmReporte();
            fr.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == (DialogResult.OK))
            { 
                Close();
            }
        }

        private void principalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmReporte fr = new frmReporte();
            fr.ShowDialog();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultarVentas fr = new frmConsultarVentas();
            fr.ShowDialog();
        }
    }
}
