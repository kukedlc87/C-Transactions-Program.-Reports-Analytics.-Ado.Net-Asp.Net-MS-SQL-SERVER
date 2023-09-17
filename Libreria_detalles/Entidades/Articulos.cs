using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_detalles
{
    internal class Articulos
    {
        int id_articulo;
        string descripcion;
        double pre_unitario;
        public Articulos()
        {
            descripcion = string.Empty;
            pre_unitario = 0;
            id_articulo = 0;
        }

        public Articulos(string descripcion, double pre_unitario, int id_articulo)
        {
            this.Descripcion = descripcion;
            this.Pre_unitario = pre_unitario;
            this.Id_articulo = id_articulo; 
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Pre_unitario { get => pre_unitario; set => pre_unitario = value; }
        public int Id_articulo { get => id_articulo; set => id_articulo = value; }
    }
}
