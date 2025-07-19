using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorCategoria
    {
        public List<BE.Categoria> ObtenerCategorias()
        {
            DAL.CategoriaDAL categoriaDAL = new DAL.CategoriaDAL();
            DataTable tabla = categoriaDAL.ObtenerCategorias();

            List<BE.Categoria> categorias = new List<BE.Categoria>();

            foreach (DataRow fila in tabla.Rows) {
                categorias.Add(
                    new BE.Categoria
                    {
                        IDCategoria = Convert.ToInt32(fila["IdCategoria"]),
                        NombreCategoria = fila["NombreCategoria"].ToString(),
                    }
                 );
            }
            return categorias;
        }
    }
}
