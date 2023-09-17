using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria_detalles
{
    internal class Conexion
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=kuke;Initial Catalog=LIBRERIA;Integrated Security=True");
        SqlCommand cmd;


        public void Conectar()
        {
        cnn.Open(); 
        cmd = new SqlCommand();
        cmd.Connection = cnn;

        }

        public void Desconectar()
        { 
                cnn.Close();
        
        }

        public DataTable ReaderSP(string sp)
        {
            Conectar();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Desconectar();
            return dt;
        
        }

        public DataTable ReaderSP(string sp, List<SqlParameter> list)
        {
            Conectar();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            DataTable dt = new DataTable();
            foreach (SqlParameter p in list)
            {
                cmd.Parameters.Add(p);

            }
            dt.Load(cmd.ExecuteReader());
            Desconectar();
            return dt;

        }

        public int UltimoId()
        {
            
            Conectar();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ultimo_id";
            SqlParameter p = new SqlParameter();
            p.ParameterName = "@ultimo";
            p.Direction = ParameterDirection.Output;
            p.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p);
            cmd.ExecuteNonQuery();
            Desconectar();
            return (int)p.Value;

        }

        public DataTable Reader(string sp)
        {
            Conectar();
            cmd.CommandText = sp;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Desconectar();
            return dt;

        }

        public void ConfirmarFactura(Factura nuevaFactura)
        {
            bool resultado = true;
            SqlTransaction t = null;

            
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "nueva_factura";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@cod_cliente";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Input;
                parametro.Value = nuevaFactura.Cod_cliente.ToString();
                cmd.Parameters.Add(parametro);
                SqlParameter parametro2 = new SqlParameter();
                parametro2.ParameterName = "@cod_vendedor";
                parametro2.SqlDbType = SqlDbType.Int;
                parametro2.Direction = ParameterDirection.Input;
                parametro2.Value = nuevaFactura.Cod_vendedor.ToString();

                cmd.Parameters.Add(parametro2);


                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = cnn;
                cmd2.Transaction = t;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "ultimo_id";
                SqlParameter p = new SqlParameter();
                p.ParameterName = "@ultimo";
                p.Direction = ParameterDirection.Output;
                p.SqlDbType = SqlDbType.Int;
                cmd2.Parameters.Add(p);
                cmd2.ExecuteNonQuery();
               int nro_factura = (int)p.Value;

                SqlCommand cmdDetalle;
                foreach (Detalle dt in nuevaFactura.Detalles)
                { 
                    cmdDetalle = new SqlCommand();
                    cmdDetalle.Connection = cnn;
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.CommandText = "insertar_detalle";
                    cmdDetalle.Transaction = t;
                    cmdDetalle.Parameters.AddWithValue("@nro_factura", nro_factura);
                    cmdDetalle.Parameters.AddWithValue("@cod_articulo",dt.Articulos.Id_articulo );
                    cmdDetalle.Parameters.AddWithValue("@pre_unitario", dt.Articulos.Pre_unitario);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", dt.Cantidad);
                    cmdDetalle.ExecuteNonQuery();


                }


                t.Commit();
                MessageBox.Show("algo paso");

           
            
            cnn.Close();

        
        
        
        
        
        }


        public void Agregar(string sp, List<SqlParameter> list )
        {
            Conectar();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            foreach (SqlParameter p in list ) 
            {
            cmd.Parameters.Add( p );
            
            }
            cmd.ExecuteNonQuery();

            Desconectar();
        
        }

    }
}
