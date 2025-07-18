using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorDeProductos
    {
        public void AgregarProductos(BE.Producto unProducto)
        {
            DAL.ProductoDAL productoDAL = new DAL.ProductoDAL();
            productoDAL.AgregarProductos(unProducto);
        }
    }
}
