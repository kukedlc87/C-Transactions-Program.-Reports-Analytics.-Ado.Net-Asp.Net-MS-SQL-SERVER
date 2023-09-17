using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_detalles
{
    internal class Clientes
    {
        string nombre;
        int id_cliente;

        public Clientes()
        {
            nombre = string.Empty; 
            id_cliente = 0;
         
        }

        public Clientes(string nombre, int id_cliente)
        {
            this.Nombre = nombre;
            this.Id_cliente = id_cliente;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
    }
}
