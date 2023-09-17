using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_detalles
{
    internal class Detalle
    {
        private Articulos articulos;
        int cantidad;
        public Detalle()
        {
            Articulos = null;
            Cantidad = 0;
        }

        public Detalle(Articulos articulos, int cantidad)
        {
            this.Articulos = articulos;
            this.Cantidad = cantidad;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        internal Articulos Articulos { get => articulos; set => articulos = value; }

        public double CalcularTotal()
        {
            return articulos.Pre_unitario * cantidad;

        }
    }
}
