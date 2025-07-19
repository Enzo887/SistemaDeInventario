using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
