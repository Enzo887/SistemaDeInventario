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

        public List<BE.Producto> ObtenerProductos() 
        {
            DataTable tabla = productoDAL.ObtenerProductos();

            List<BE.Producto> productos = new List<BE.Producto>();

            foreach (DataRow fila in tabla.Rows)
            {
                productos.Add(
                    new BE.Producto
                    {
                        IDProducto = Convert.ToInt32(fila["IdProducto"]),
                        NombreProducto = fila["NombreProducto"].ToString(),
                        Precio = Convert.ToDecimal(fila["Precio"]),
                        Cantidad = Convert.ToInt32(fila["Cantidad"]),
                    }
                 );
            }
            return productos;
        }

    }
}
