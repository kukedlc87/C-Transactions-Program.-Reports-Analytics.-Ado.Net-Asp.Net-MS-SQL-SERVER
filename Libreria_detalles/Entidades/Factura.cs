using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Libreria_detalles
{
    internal class Factura
    {
        private int nro_factura;
        private Clientes cliente;
        private DateTime fecha;
        private List<Detalle> detalles;
        private int cod_vendedor;
        private int cod_cliente;

       
        public Factura()
        {
            Detalles = new List<Detalle>();

        }
        public void AgregarDetalles(Detalle detalle) 
        {
            Detalles.Add(detalle);
        }


        public int Nro_factura { get => nro_factura; set => nro_factura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Cod_vendedor { get => cod_vendedor; set => cod_vendedor = value; }
        public int Cod_cliente { get => cod_cliente; set => cod_cliente = value; }
        internal Clientes Cliente { get => cliente; set => cliente = value; }
        internal List<Detalle> Detalles { get => detalles; set => detalles = value; }
    }
}
