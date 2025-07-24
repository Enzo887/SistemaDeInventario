using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaDAL
    {
        Conexion conexion = new Conexion();

        public DataTable ObtenerCategorias()
        {
            try
            {
                return conexion.LeerPorComando("SELECT * FROM V_ObtenerCategorias");
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en obtener los datos de la tabla categoria en la BD",e);
            }
            
        }

        public void AgregarCategoria(BE.Categoria nuevaCategoria)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@NombreCategoria",nuevaCategoria.NombreCategoria)
                };
                conexion.EscribirPorStoreProcedure("SP_AgregarCategoria", parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en el INSERT de la categoria en la BD", e);
            }
            
        }

        public bool ExisteCategoria(BE.Categoria nuevaCategoria)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@NombreCategoria",nuevaCategoria.NombreCategoria)
                };

                DataTable resultado = conexion.LeerPorStoreProcedure("SP_BuscarCategoriaDuplicada", parametros);

                //es 1 si tiene coincidencia
                return resultado.Rows.Count > 0;
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en el SELECT de la categoria en la BD", e);
            }
        }

        public void EditarCategoria(BE.Categoria categoriaEditada)
        {
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    
                    new SqlParameter("@NombreCategoria", categoriaEditada.NombreCategoria),
                    new SqlParameter("@IdCategoria", categoriaEditada.IDCategoria)
                };

                conexion.EscribirPorStoreProcedure("SP_ActualizarCategoria", parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error en el UPDATE de la categoria en la BD",e);
            }

        }
    }
}
