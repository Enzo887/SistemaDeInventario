using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorCategoria
    {
        
        private DAL.CategoriaDAL categoriaDAL = new DAL.CategoriaDAL();

        public List<BE.Categoria> ObtenerCategorias()
        {
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

        public void AgregarCategoria(BE.Categoria nuevaCategoria)
        {
            categoriaDAL.AgregarCategoria(nuevaCategoria);      
        }

        public void EditarCategoria(BE.Categoria categoriaEditada)
        {
            categoriaDAL.EditarCategoria(categoriaEditada);   
        }

        public bool ExisteCategoria (BE.Categoria categoriaExiste)
        {
            return categoriaDAL.ExisteCategoria(categoriaExiste);
        }

        public void EliminarCategoria(BE.Categoria categoriaAEliminar)
        {
            categoriaDAL.EliminarCategoria (categoriaAEliminar);
        }

        public bool CategoriaTieneProductos(int idCategoria)
        {
            return categoriaDAL.CategoriaTieneProducto(idCategoria);
        }
    }
}
