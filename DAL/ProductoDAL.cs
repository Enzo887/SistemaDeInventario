using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoDAL
    {
        Conexion conexion = new Conexion();

        public void AgregarProductos(BE.Producto unProducto)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                            {
                new SqlParameter("@NombreProducto", unProducto.NombreProducto),
                new SqlParameter("@Precio", unProducto.Precio),
                new SqlParameter("@Cantidad", unProducto.Cantidad),
                new SqlParameter("@IdCategoria", unProducto.Categoria.IDCategoria),
                new SqlParameter("@FechaIngreso", unProducto.FechaIngreso),
                new SqlParameter("@FechaVencimiento", unProducto.FechaVencimiento)
                            };
                conexion.EscribirPorStoreProcedure("SP_AgregarProductos", parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en el INSERT del producto en la BD", e);
            }
        }

        public DataTable ObtenerProductos()
        {
            try
            {
                return conexion.LeerPorComando("SELECT * FROM V_ObtenerProductos");
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en obtener los datos de la tabla productos en la BD", e);
            }
        }

        public void EliminarProducto(BE.Producto unProducto)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                            {
                new SqlParameter("@IdProducto",unProducto.IDProducto)
                            };
                conexion.EscribirPorStoreProcedure("SP_EliminarProducto", parametros);
            }
            catch (Exception e)
            {

                throw new Exception("Hubo un error en el DELETE del producto en la BD", e);
            }

        }




    }
}
