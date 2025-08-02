using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class GestorProducto
    {
        DAL.ProductoDAL productoDAL = new DAL.ProductoDAL();
        public void AgregarProductos(BE.Producto unProducto)
        {
            productoDAL.AgregarProductos(unProducto);
        }

        public List<BE.Producto> ObtenerProductos(bool incluirEliminados) 
        {
            DataTable tabla = productoDAL.ObtenerProductos(incluirEliminados);

            List<BE.Producto> productos = new List<BE.Producto>();

            foreach (DataRow fila in tabla.Rows)
            {
                BE.Categoria unaCategoria = new BE.Categoria();
                BE.Producto unProducto = new BE.Producto();
                unProducto.IDProducto = Convert.ToInt32(fila["IdProducto"]);
                unProducto.NombreProducto = fila["NombreProducto"].ToString();
                unProducto.Precio = Convert.ToDecimal(fila["Precio"]);
                unProducto.Cantidad = Convert.ToInt32(fila["Cantidad"]);
                unProducto.FechaVencimiento = (DateTime)fila["FechaVencimiento"];
                unProducto.Activo = (bool)fila["Activo"];
                unaCategoria.IDCategoria = Convert.ToInt32(fila["IdCategoria"]);
                unaCategoria.NombreCategoria = fila["NombreCategoria"].ToString();
                unProducto.Categoria = unaCategoria;

                productos.Add(unProducto);
            }
            return productos;
        }

        public void EliminarProducto(BE.Producto unProducto)
        {
            productoDAL.EliminarProducto(unProducto);
        }

        public bool ExisteProducto(BE.Producto producto)
        {
            return productoDAL.ExisteProducto(producto);
        }

        public void EditarProducto(BE.Producto productoEditado)
        {
            productoDAL.EditarProducto(productoEditado);
        }
    }
}
