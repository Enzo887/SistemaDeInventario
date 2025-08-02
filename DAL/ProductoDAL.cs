using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

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

        public DataTable ObtenerProductos(bool incluirEliminados)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@incluirEliminados",incluirEliminados)
                            };
                 return conexion.LeerPorStoreProcedure("SP_ObtenerProductos", parametros);
                    
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


        public bool ExisteProducto(BE.Producto producto)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@NombreProducto", producto.NombreProducto)
                };

                DataTable resultado = conexion.LeerPorStoreProcedure("SP_BuscarProductoDuplicado", parametros);

                return resultado.Rows.Count > 0;
            }
            catch (Exception e)
            {

                throw new Exception("Hubo un error en el SELECT de existencia duplicada del producto en la BD", e);
            }
        }


        public void EditarProducto(BE.Producto productoEditado)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@idProducto", productoEditado.IDProducto),
                    new SqlParameter("@NombreProducto", productoEditado.NombreProducto),
                    new SqlParameter("@Precio", productoEditado.Precio),
                    new SqlParameter("@Cantidad", productoEditado.Cantidad),
                    new SqlParameter("@idCategoria", productoEditado.Categoria.IDCategoria),
                    new SqlParameter("@FechaVencimiento", productoEditado.FechaVencimiento),
                    new SqlParameter("@Activo", productoEditado.Activo)
                };
                conexion.EscribirPorStoreProcedure("SP_ActualizarProducto", parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en el UPDATE del producto en la BD", e);
            }
        }




    }
}
